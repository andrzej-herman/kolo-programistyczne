import React from "react";
import { Container, Row, Col } from "react-bootstrap";
import MainPageInfoContainer from "./components/MainPageInfoContainer";

const App = () => {
  return (
    <Container>
      <Row>
        <Col>
          <div>Logowanie</div>
        </Col>
        <Col>
          <div>Reklama</div>
        </Col>
      </Row>
      <MainPageInfoContainer />
    </Container>
  );
};

export default App;
