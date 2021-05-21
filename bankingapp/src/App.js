import React from "react";
import "./components/MainPage/MainPage.css";
import { Container } from "react-bootstrap";
import MainPageHeader from "./components/MainPage/MainPageHeader";
import MainPageInfoContainer from "./components/MainPage/MainPageInfoContainer";
import MainPageLoginContainer from "./components/MainPage/MainPageLoginContainer";
import HorizontalDivider from "./components/Common/HorizontalDivider";

const App = () => {
  return (
    <Container>
      <MainPageHeader />
      <MainPageLoginContainer />
      <HorizontalDivider />
      <MainPageInfoContainer />
    </Container>
  );
};

export default App;
