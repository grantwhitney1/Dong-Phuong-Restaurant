export type SignInForm = {
  email: string,
  password: string
}

export type SignupForm = {
  email: string,
  password: string,
  confirmPassword: string
}

export type ForgotPasswordForm = {
  email: string,
}

export type ResetPasswordForm = {
  email: string,
  resetCode: string,
  newPassword: string
}

export type Manage2faForm = {
  enable: boolean,
  twoFactorCode: string,
  resetSharedKey: boolean,
  resetRecoveryCode: boolean,
  forgetMachine: boolean
}

export type ManageInfoForm = {
  newEmail: string,
  newPassword: string,
  oldPassword: string
}

export interface ConfirmEmailResponse {
  userId: string,
  code: string,
  changedEmail: string
}

export interface GetManageInfoResponse {
  email: string,
  isEmailConfirmed: boolean,
}