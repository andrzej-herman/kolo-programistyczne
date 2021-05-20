import React from "react";
import { Col } from "react-bootstrap";

const MainPageInfo = (props) => {
  return (
    <Col>
      <p className="main-page-info-date">{props.x.date}</p>
      <p className="main-page-info-title">{props.x.title}</p>
      <p className="main-page-info-content">{props.x.content}</p>
    </Col>
  );
};

export default MainPageInfo;
