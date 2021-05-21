import React from "react";
import { Col } from "react-bootstrap";
import { getPolishDate } from "../../helpers/helper";

const MainPageInfo = (props) => {
  return (
    <Col className="main-page-info-col">
      <p className="main-page-info-date">{getPolishDate(props.x.date)}</p>
      <p className="main-page-info-title">{props.x.title}</p>
      <p className="main-page-info-content">{props.x.content}</p>
    </Col>
  );
};

export default MainPageInfo;
