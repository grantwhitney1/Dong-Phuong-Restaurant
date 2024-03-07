import {useMutation, useQuery} from "@tanstack/react-query";
import {
  ConfirmEmailResponse,
  ForgotPasswordForm,
  Manage2faForm, ManageInfoForm, GetManageInfoForm,
  ResetPasswordForm,
  SignInForm,
  SignupForm
} from "../../types/authentication/auth";
import {apiBaseUrl} from "../../utils/vite-env.ts";

const signIn = async (credentials: SignInForm) => {
  const url = new URL(`${apiBaseUrl}/login?useCookies=true`);
  const response = await fetch(url.toString(), {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(credentials),
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');
  return response.json();
}

export const useSignIn = () => {
  return useMutation({mutationFn: signIn});
}

const signup = async (credentials: SignupForm) => {
  const url = new URL(`${apiBaseUrl}/register`);
  const response = await fetch(url.toString(), {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(credentials),
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');
  return response.json();
}

export const useSignup = () => {
  return useMutation({mutationFn: signup});
}

const forgotPassword = async (credentials: ForgotPasswordForm) => {
  const url = new URL(`${apiBaseUrl}/forgotPassword`);
  const response = await fetch(url.toString(), {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(credentials),
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');
  return response.json();
}

export const useForgotPassword = () => {
  return useMutation({mutationFn: forgotPassword});
}

const resetPassword = async (credentials: ResetPasswordForm) => {
  const url = new URL(`${apiBaseUrl}/resetPassword`);
  const response = await fetch(url.toString(), {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(credentials),
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');
  return response.json();
}

export const useResetPassword = () => {
  return useMutation({mutationFn: resetPassword});
}

const manage2fa = async (credentials: Manage2faForm) => {
  const url = new URL(`${apiBaseUrl}/manage/2fa`);
  const response = await fetch(url.toString(), {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(credentials),
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');
  return response.json();
}

export const useManage2fa = () => {
  return useMutation({mutationFn: manage2fa});
}

const manageInfo = async (credentials: ManageInfoForm) => {
  const url = new URL(`${apiBaseUrl}/manage/info`);
  const response = await fetch(url.toString(), {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(credentials),
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');
  return response.json();
}

export const useManageInfo = () => {
  return useMutation({mutationFn: manageInfo});
}

const signOut = async () => {
  const url = new URL(`${apiBaseUrl}/logout`);
  const response = await fetch(url.toString(), {
    method: 'POST',
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');
  return response.json();
}

export const useSignOut = () => {
  return useMutation({mutationFn: signOut});
}

const confirmEmail = async (userId: string, code: string, changedEmail?: string): Promise<ConfirmEmailResponse> => {
  const url = new URL(`${apiBaseUrl}/confirmEmail`);
  url.searchParams.append('userId', userId);
  url.searchParams.append('code', code);
  if (changedEmail) {
    url.searchParams.append('changedEmail', changedEmail);
  }
  
  const response = await fetch(url.toString(), {
    method: 'GET',
    headers: {
      'Content-Type': 'application/json',
    },
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');
  return response.json();
}

export const useConfirmEmail = (userId: string, code: string, changedEmail?: string) => {
  return useQuery<ConfirmEmailResponse, Error>({
    queryKey: ['confirmEmail', userId, code, changedEmail],
    queryFn: () => confirmEmail(userId, code, changedEmail),
    enabled: !!userId && !!code,
  });
}

const getManageInfo = async (credentials: GetManageInfoForm): Promise<GetManageInfoForm> => {
  const url = new URL(`${apiBaseUrl}/manageInfo`);
  const response = await fetch(url.toString(), {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(credentials),
  });

  if (!response.ok)
    throw new Error('There was a problem receiving the network response.');
  return response.json();
}

export const useGetManageInfo = (credentials: GetManageInfoForm) => {
  return useQuery<GetManageInfoForm, Error>({
    queryKey: ['manageInfo', credentials],
    queryFn: () => getManageInfo(credentials),
    enabled: !!credentials,
  });
}