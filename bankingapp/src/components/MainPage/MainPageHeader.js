import React from "react";
import { Row, Col } from "react-bootstrap";
import Logo from "../../images/logo.png";

const MainPageHeader = () => {
  return (
    <Row>
      <Col className="main-page-header">
        <img className="main-page-logo" src={Logo} alt="Logo" />
        <p>Aplikacja studencka wirtualnego banku SanBank</p>
      </Col>
    </Row>
  );
};

export default MainPageHeader;
