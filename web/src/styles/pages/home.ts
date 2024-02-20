import {styled} from "@mui/system";
import {Box} from "@mui/material";

export const StyledOuterBox = styled(Box)(() => ({
  width: '80%',
  display: 'flex',
  flexDirection: 'column',
  justifyContent: 'center',
  textAlign: 'left',
  margin: '0 auto 0 auto'
}));

export const StyledInnerBox = styled(Box)(() => ({
  width: '100%',
  display: 'flex',
  flexDirection: 'row',
  justifyContent: 'space-evenly',
  margin: '0 auto 0 auto'
}));

export const StyledH1 = styled('h1')(() => ({
  marginTop: '1.5rem',
  marginBottom: 0,
  fontWeight: '600',
  color: '#18241c',
}));

export const StyledH4 = styled('h4')(() => ({
  width: '95%',
  margin: '0 auto 0 auto',
  fontWeight: '500',
  color: '#18241c',
}));

export const StyledP = styled('p')(() => ({
  width: '85%',
  textIndent: '2rem',
  margin: '1rem auto 16rem auto',
  fontWeight: '400',
  color: '#18241c',
}));

export const StyledImg = styled('img')(() => ({
  margin: '1.5rem',
  boxShadow: '0 0 2rem rgba(0, 0, 0, 0.18)',
  borderRadius: '1rem'
}));