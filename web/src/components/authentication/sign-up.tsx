import {SetStateAction, useState} from "react";
import {useSignUp} from "../../hooks/authentication/auth-service.ts";
import {Box, Button, TextField, Typography} from "@mui/material";

const SignUp = ({onClose: onClose}: { onClose: () => unknown }) => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const signUp = useSignUp();

  const handleEmailChange = (event: { target: { value: SetStateAction<string> } }) => {
    setEmail(event.target.value);
  }

  const handlePasswordChange = (event: { target: { value: SetStateAction<string> } }) => {
    setPassword(event.target.value);
  }

  const handleConfirmPasswordChange = (event: { target: { value: SetStateAction<string> } }) => {
    setConfirmPassword(event.target.value);
  }

  const handleSubmit = async (event: { preventDefault: () => void; }) => {
    event.preventDefault();
    signUp.mutate({email, password, confirmPassword}, {
      onSuccess: () => {
        onClose();
      },
    });
  };

  return (
    <Box
      component='form'
      onSubmit={handleSubmit}
      noValidate
    >
      <Typography>
        Sign Up
      </Typography>
      <TextField
        required
        id='sign-up-email'
        label='Email Address'
        name='email'
        autoComplete='email'
        autoFocus
        value={email}
        onChange={handleEmailChange}
        error={signUp.isError ?? false}
      />
      <TextField
        required
        type='password'
        id='sign-up-password'
        label='Password'
        name='password'
        autoComplete='current-password'
        autoFocus
        value={password}
        onChange={handlePasswordChange}
        error={signUp.isError ?? false}
      />
      <TextField
        required
        type='password'
        id='sign-up-confirm-password'
        label='Confirm Password'
        name='confirm-password'
        autoComplete='new-password'
        autoFocus
        value={confirmPassword}
        onChange={handleConfirmPasswordChange}
        error={signUp.isError ?? false}
      />
      <Typography>
        {signUp.error ? signUp.error.message + signUp.error.cause?.toString() + signUp.error.stack?.toString() : ''}
      </Typography>
      <Button
        type='submit'
        disabled={signUp.isPending || signUp.isPaused}
      >
        Sign In
      </Button>
    </Box>
  );
}

export default SignUp;