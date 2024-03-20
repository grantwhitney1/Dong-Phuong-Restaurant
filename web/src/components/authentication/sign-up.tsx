import {SetStateAction, useEffect, useState} from "react";
import {useSignUp} from "../../hooks/authentication/auth-service";
import {StyledButton, StyledForm, StyledTextField} from "../../styles/components/authentication/sign-up";

const SignUp = ({onClose: onClose}: { onClose: () => unknown }) => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const [helperText, setHelperText] = useState('');
  const [disabled, setDisabled] = useState(true);
  const [isError, setIsError] = useState(false);
  const signUp = useSignUp();

  const handleEmailChange = (event: { target: { value: SetStateAction<string> } }) => {
    setEmail(event.target.value);
    setIsError(false);
    setHelperText('');
  }

  const handlePasswordChange = (event: { target: { value: SetStateAction<string> } }) => {
    setPassword(event.target.value);
    setIsError(false);
    setHelperText('');
  }

  const handleConfirmPasswordChange = (event: { target: { value: SetStateAction<string> } }) => {
    setConfirmPassword(event.target.value);
    setIsError(false);
    setHelperText('');
  }

  useEffect(() => {
    isError || signUp.isPending || signUp.isPaused ||
    email === '' || password === '' ?
      setDisabled(true) : setDisabled(false);
  }, [isError, signUp, email, password]);

  const handleSubmit = async (event: { preventDefault: () => void; }) => {
    event.preventDefault();
    signUp.mutate({email, password, confirmPassword}, {
      onSuccess: () => {
        onClose();
      },
      onError: (error) => {
        setHelperText(error.message);
        setIsError(true);
      }
    });
  };

  return (
    <StyledForm
      onSubmit={handleSubmit}
      noValidate
    >
      <StyledTextField
        required
        id='sign-up-email'
        label='Email Address'
        name='email'
        autoComplete='email'
        autoFocus
        value={email}
        onChange={handleEmailChange}
        error={isError}
      />
      <StyledTextField
        required
        type='password'
        id='sign-up-password'
        label='Password'
        name='password'
        autoComplete='current-password'
        autoFocus
        value={password}
        onChange={handlePasswordChange}
        error={isError}
      />
      <StyledTextField
        required
        type='password'
        id='sign-up-confirm-password'
        label='Confirm Password'
        name='confirm-password'
        autoComplete='new-password'
        autoFocus
        value={confirmPassword}
        onChange={handleConfirmPasswordChange}
        error={isError}
        helperText={helperText}
      />
      <StyledButton
        type='submit'
        disabled={disabled}
      >
        Sign In
      </StyledButton>
    </StyledForm>
  );
}

export default SignUp;