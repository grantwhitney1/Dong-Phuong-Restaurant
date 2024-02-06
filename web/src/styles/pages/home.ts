import {styled} from "@mui/system";
import {Box} from "@mui/material";

export const StyledOuterBox = styled(Box)(() => ({
  width: '66%',
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
  justifyContent: 'center',
  margin: '0 auto 0 auto'
}));

export const StyledH1 = styled('h1')(() => ({
  marginTop: '1.5rem',
  marginBottom: '1.5rem',
  color: '#1c1c1c',
}));

export const StyledH3 = styled('h3')(() => ({
  fontFamily: "'Nunito Sans', sans-serif",
  width: '85%',
  margin: '1rem auto 1rem auto',
  color: '#1c1c1c',
}));

export const StyledP = styled('p')(() => ({
  fontFamily: "'Nunito Sans', sans-serif",
  width: '85%',
  textIndent: '2rem',
  margin: '0.5rem auto 0.5rem auto',
  color: '#1c1c1c',
}));

export const StyledImg = styled('img')(() => ({
  margin: '1.5rem',
  boxShadow: '0 0 2rem rgba(0, 0, 0, 0.18)',
  borderRadius: '1rem'
}));