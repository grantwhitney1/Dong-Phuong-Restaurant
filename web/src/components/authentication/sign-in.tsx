import {SetStateAction, useState} from "react";
import {useSignIn} from "../../hooks/authentication/auth-service.ts";
import {Button, TextField, Typography} from "@mui/material";
import {StyledBox} from "../../styles/components/authentication/sign-in.ts";

const SignIn = ({onClose: onClose}: { onClose: () => unknown }) => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const signIn = useSignIn();

  const handleEmailChange = (event: { target: { value: SetStateAction<string> } }) => {
    setEmail(event.target.value);
  }

  const handlePasswordChange = (event: { target: { value: SetStateAction<string> } }) => {
    setPassword(event.target.value);
  }

  const handleSubmit = async (event: { preventDefault: () => void; }) => {
    event.preventDefault();
    signIn.mutate({email, password}, {
      onSuccess: () => {
        onClose();
      },
    });
  };

  return (
    <StyledBox
      component='form'
      onSubmit={handleSubmit}
    >
      <TextField
        required
        id='sign-in-email'
        label='Email Address'
        name='email'
        autoComplete='email'
        autoFocus
        value={email}
        onChange={handleEmailChange}
        error={signIn.isError ?? false}
      />
      <TextField
        required
        type='password'
        id='sign-in-password'
        label='Password'
        name='password'
        autoComplete='current-password'
        autoFocus
        value={password}
        onChange={handlePasswordChange}
        error={signIn.isError ?? false}
      />
      <Typography>
        {signIn.error ? signIn.error.message : ''}
      </Typography>
      <Button
        type='submit'
        disabled={signIn.isPending || signIn.isPaused}
      >
        Sign In
      </Button>
    </StyledBox>
  );
}

export default SignIn;