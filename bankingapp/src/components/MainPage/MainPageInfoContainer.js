import React, { useState, useEffect } from "react";
import { Row } from "react-bootstrap";
import MainPageInfo from "./MainPageInfo";
import API from "../../axios/api";

const MainPageInfoContainer = () => {
  const [info, setInfo] = useState(null);

  useEffect(() => {
    API.get("api/mainpage")
      .then((response) => {
        setInfo(response.data);
      })
      .catch((error) => {
        console.error(error);
      });
  }, []);

  return (
    <Row className="main-page-info">
      {info
        ? info.map((item) => (
            <MainPageInfo x={item} key={item.mainPageInfoId} />
          ))
        : null}
    </Row>
  );
};

export default MainPageInfoContainer;
