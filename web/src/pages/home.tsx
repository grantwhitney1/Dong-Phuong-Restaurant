import {StyledH1, StyledH4, StyledImg, StyledInnerBox, StyledOuterBox, StyledP} from "../styles/pages/home";

const Home = () => {
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
        Welcome to Dong Phuong Vietnamese Restaurant
      </StyledH1>
      <StyledH4>
        This is the sample landing page. Here, we can see an example color scheme and font styling.
      </StyledH4>
      <StyledP>
        Dong Phuong Restaurant offers a diverse menu that includes appetizers like fried shrimp & pork egg rolls and
        shrimp & pork spring rolls, various rice vermicelli bowls with choices like grilled chicken, pork, beef, and
        shrimp, vermicelli rolls, grilled dishes with pork, chicken, beef, shrimp, and tofu, salads, several dressing
        options, an array of phở options including combination, brisket, eye of round, meatball, and shrimp, specialty
        soups, beverages like chicory coffee, limeade, soy milk, and teas, along with tapioca drinks available in
        various flavors such as avocado, banana, mango, and more, with the option for additional toppings.
      </StyledP>
    </StyledOuterBox>
  );
}

export default Home;