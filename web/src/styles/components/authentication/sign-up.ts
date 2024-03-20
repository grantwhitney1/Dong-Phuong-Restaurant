import {Button, OutlinedInput, TextField} from "@mui/material";
import {styled} from "@mui/system";
import {blue} from "@mui/material/colors";

export const StyledForm = styled('form')({
  display: 'flex',
  flexDirection: 'column'
});

export const StyledOutlinedInput = styled(OutlinedInput)({
  borderRadius: '50vw',
});

export const StyledTextField = styled(TextField)({
  marginTop: '2rem',
});

export const StyledButton = styled(Button)({
  margin: '2rem',
  backgroundColor: `${blue[50]}80`,
  '&:hover': {
    backgroundColor: `${blue[50]}`
  }
});