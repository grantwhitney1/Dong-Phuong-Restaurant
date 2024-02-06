
import {StyledH1, StyledH3, StyledImg, StyledInnerBox, StyledOuterBox, StyledP} from "../styles/pages/home";

const Home = () => {
  return (
    <StyledOuterBox>
      <StyledH1>
        Welcome to Dong Phuong Restaurant&apos;s Website
      </StyledH1>
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