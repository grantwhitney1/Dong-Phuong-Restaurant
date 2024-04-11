import {useMutation, useQuery} from "@tanstack/react-query";
import {
  ConfirmEmailResponse,
  ForgotPasswordForm,
  GetManageInfoResponse,
  Manage2faForm,
  ManageInfoForm,
  ResetPasswordForm,
  SignInForm,
  SignupForm
} from "../../types/authentication/auth";
import {apiBaseUrl} from "../../utils/vite-env";
import {useUserStore} from "../../../store";

const authenticationResponse: (credentials: unknown, url: URL) => Promise<unknown> = async (credentials, url: URL) => {
  const response = await fetch(url.toString(), {
    mode: 'cors',
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
      'Access-Control-Allow-Origin': '*',
    },
    body: JSON.stringify(credentials)
  });

  if (!response.ok) {
    if (response.status === 401 || response.status === 400)
      throw new Error('The credentials given were not valid.');
    else
      throw new Error('There was a problem receiving the network response.');
  }

  if (typeof credentials === 'object' && credentials !== null && 'email' in credentials) {
    const validCredentials = credentials as { email: string };
    useUserStore.getState().setUser({email: validCredentials.email, isAuthenticated: true});
  }

  return response.bodyUsed ? response.json() : response.statusText;
};

const signIn = async (credentials: SignInForm) => {
  const url = new URL(`${apiBaseUrl}login?useCookies=true`);
  return await authenticationResponse(credentials, url);
}

export const useSignIn = () => {
  return useMutation({mutationFn: signIn});
}

const signup = async (credentials: SignupForm) => {
  const url = new URL(`${apiBaseUrl}register`);
  return await authenticationResponse(credentials, url);
}

export const useSignUp = () => {
  return useMutation({mutationFn: signup});
}

const forgotPassword = async (credentials: ForgotPasswordForm) => {
  const url = new URL(`${apiBaseUrl}forgotPassword`);
  return await authenticationResponse(credentials, url);
}

export const useForgotPassword = () => {
  return useMutation({mutationFn: forgotPassword});
}

const resetPassword = async (credentials: ResetPasswordForm) => {
  const url = new URL(`${apiBaseUrl}resetPassword`);
  return await authenticationResponse(credentials, url);
}

export const useResetPassword = () => {
  return useMutation({mutationFn: resetPassword});
}

const manage2fa = async (credentials: Manage2faForm) => {
  const url = new URL(`${apiBaseUrl}manage/2fa`);
  return await authenticationResponse(credentials, url);
}

export const useManage2fa = () => {
  return useMutation({mutationFn: manage2fa});
}

const manageInfo = async (credentials: ManageInfoForm) => {
  const url = new URL(`${apiBaseUrl}manage/info`);
  return await authenticationResponse(credentials, url);
}

export const useManageInfo = () => {
  return useMutation({mutationFn: manageInfo});
}

const signOut = async () => {
  const url = new URL(`${apiBaseUrl}logout`);
  const response = await fetch(url.toString(), {
    mode: 'cors',
    headers: {
      'Content-Type': 'application/json',
      'Access-Control-Allow-Origin': '*',
    },
    credentials: 'include',
    method: 'POST',
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');

  useUserStore.getState().setUser({email: '', isAuthenticated: false});

  return response.bodyUsed ? response.json() : response.statusText;
}

export const useSignOut = () => {
  return useMutation({mutationFn: signOut});
}

const confirmEmail = async (userId: string, code: string, changedEmail?: string): Promise<ConfirmEmailResponse> => {
  const url = new URL(`${apiBaseUrl}confirmEmail`);
  url.searchParams.append('userId', userId);
  url.searchParams.append('code', code);
  if (changedEmail) {
    url.searchParams.append('changedEmail', changedEmail);
  }

  const response = await fetch(url.toString(), {
    mode: 'cors',
    method: 'GET',
    headers: {
      'Content-Type': 'application/json',
      'Access-Control-Allow-Origin': '*',
    },
    credentials: 'include'
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');
  return response.bodyUsed ? response.json() : response.statusText;
}

export const useConfirmEmail = (userId: string, code: string, changedEmail?: string) => {
  return useQuery<ConfirmEmailResponse, Error>({
    queryKey: ['confirmEmail', userId, code, changedEmail],
    queryFn: () => confirmEmail(userId, code, changedEmail),
    enabled: !!userId && !!code,
  });
}

const getManageInfo = async (): Promise<GetManageInfoResponse> => {
  const url = new URL(`${apiBaseUrl}manage/info`);
  const response = await fetch(url.toString(), {
    mode: 'cors',
    method: 'GET',
    headers: {
      'Content-Type': 'application/json',
      'Access-Control-Allow-Origin': '*',
    },
    credentials: 'include'
  });

  if (!response.ok && response.status !== 401)
    throw new Error('There was a problem receiving the network response.');
  return response.bodyUsed ? response.json() : response.statusText;
}

export const useGetManageInfo = () => {
  return useQuery<GetManageInfoResponse, Error>({
    queryKey: ['manageInfo'],
    queryFn: () => getManageInfo(),
  });
}