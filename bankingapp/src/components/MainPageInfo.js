import React from "react";
import { Col } from "react-bootstrap";

const MainPageInfo = ({ info }) => {
  return (
    <Col>
      <p className="main-page-info-date">{info.date}</p>
      <p className="main-page-info-title">{info.title}</p>
      <p className="main-page-info-content">{info.content}</p>
    </Col>
  );
};

export default MainPageInfo;
