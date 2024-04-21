import {Button, OutlinedInput, TextField} from "@mui/material";
import {styled} from "@mui/system";
import {red} from "@mui/material/colors";

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
  backgroundColor: `${red[50]}80`,
  '&:hover': {
    backgroundColor: `${red[50]}`
  }
});