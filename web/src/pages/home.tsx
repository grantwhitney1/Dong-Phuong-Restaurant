import {styled} from '@mui/system';
import {Box} from "@mui/material";

const Home = () => {
  const StyledOuterBox = styled(Box)(() => ({
    width: '66%',
    display: 'flex',
    flexDirection: 'column',
    justifyContent: 'center',
    textAlign: 'left',
    margin: '0 auto 0 auto'
  }));

  const StyledInnerBox = styled(Box)(() => ({
    width: '100%',
    display: 'flex',
    flexDirection: 'row',
    justifyContent: 'center',
    margin: '0 auto 0 auto'
  }));

  const StyledH1 = styled('h1')(() => ({
    marginTop: '1.5rem',
    marginBottom: '1.5rem',
    color: '#1c1c1c',
  }));

  const StyledH3 = styled('h3')(() => ({
    fontFamily: "'Nunito Sans', sans-serif",
    width: '85%',
    margin: '1rem auto 1rem auto',
    color: '#1c1c1c',
  }));

  const StyledP = styled('p')(() => ({
    fontFamily: "'Nunito Sans', sans-serif",
    width: '85%',
    textIndent: '2rem',
    margin: '0.5rem auto 0.5rem auto',
    color: '#1c1c1c',
  }));

  const StyledImg = styled('img')(() => ({
    margin: '1.5rem',
    marginTop: '3rem',
    boxShadow: '0 0 2rem rgba(0, 0, 0, 0.18)',
    borderRadius: '1rem'
  }));

  return (
    <StyledOuterBox>
      <StyledInnerBox>
        <StyledImg
          src="https://www.dpbakery.com/wp-content/uploads/2022/05/order-online.png"
          alt="Vietnamese cuisine"
          width="33%"
          height="auto"
        />
        <StyledImg
          src="https://www.dpbakery.com/wp-content/uploads/2022/05/order-pickup-1.png"
          alt="Vietnamese cuisine"
          width="33%"
          height="auto"
        />
      </StyledInnerBox>
      <StyledH1>
        Welcome to Dong Phuong Restaurant&apos;s Website
      </StyledH1>
      <StyledH3>
        This is the sample landing page. Here, we can see an example color scheme and font styling.
      </StyledH3>
      <StyledP>
        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et
        dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip
        ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore
        eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia
        deserunt mollit anim id est laborum.
      </StyledP>
    </StyledOuterBox>
  );
}

export default Home;