import React from "react";
import { Row, Col } from "react-bootstrap";
import VerticalDivider from "../Common/VerticalDivider";
import Login from "./Login";
import MainPagePromo from "./MainPagePromo";

const MainPageLoginContainer = () => {
  return (
    <Row>
      <Col>
        <div className="main-page-login-container">
          <Login />
          <VerticalDivider />
          <MainPagePromo />
        </div>
      </Col>
    </Row>
  );
};

export default MainPageLoginContainer;
