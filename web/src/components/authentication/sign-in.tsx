import {SetStateAction, useEffect, useState} from "react";
import {useSignIn} from "../../hooks/authentication/auth-service";
import {StyledButton, StyledForm, StyledTextField} from "../../styles/components/authentication/sign-in";

const SignIn = ({onClose: onClose}: { onClose: () => unknown }) => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [helperText, setHelperText] = useState('');
  const [disabled, setDisabled] = useState(true);
  const [isError, setIsError] = useState(false);

  const signIn = useSignIn();

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

  useEffect(() => {
    isError || signIn.isPending || signIn.isPaused ||
    email === '' || password === '' ?
      setDisabled(true) : setDisabled(false);
  }, [isError, signIn, email, password]);

  const handleSubmit = async (event: { preventDefault: () => void; }) => {
    event.preventDefault();
    signIn.mutate({email, password}, {
      onSuccess: () => {
        onClose();
      },
      onError: (error) => {
        setHelperText(error.message);
        setIsError(true);
      }
    });
  }

  return (
    <StyledForm
      onSubmit={handleSubmit}
      noValidate
    >
      <StyledTextField
        required
        id='sign-in-email'
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
        id='sign-in-password'
        label='Password'
        name='password'
        autoComplete='current-password'
        autoFocus
        value={password}
        onChange={handlePasswordChange}
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

export default SignIn;