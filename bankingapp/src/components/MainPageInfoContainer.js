import React, { useState, useEffect } from "react";
import { Row } from "react-bootstrap";
import MainPageInfo from "./MainPageInfo";

const MainPageInfoContainer = () => {
  const [info, setInfo] = useState(null);

  useEffect(() => {
    var x = getInfo();
    setInfo(x);
  }, []);

  const getInfo = () => {
    var result = [];
    const info1 = {
      date: new Date().toDateString(),
      title: "Komunikat testowy",
      content:
        "Commodo ad ipsum esse ipsum nostrud culpa do id reprehenderit duis cillum nostrud adipisicing. Nulla ipsum dolor duis incididunt aliquip laborum Lorem pariatur id sit non nisi nulla. Id voluptate Lorem aliquip cillum enim duis occaecat id voluptate enim.",
    };
    const info2 = {
      date: new Date().toDateString(),
      title: "Komunikat testowy 2",
      content:
        "Enim Lorem et qui et non sunt ipsum. Ex aliqua aliquip eu eiusmod. Laboris ut aliqua cupidatat incididunt in adipisicing consequat eu proident eiusmod dolore. Eiusmod aliquip laboris ut labore est in anim culpa adipisicing aliquip cupidatat. Aliqua anim non sint consequat in ad duis sunt enim ipsum est sint aliquip incididunt.",
    };
    const info3 = {
      date: new Date().toDateString(),
      title: "Komunikat testowy 3",
      content:
        "Sint culpa ex exercitation exercitation eu ad reprehenderit. Aliquip quis sint eu nisi occaecat. Sint adipisicing cupidatat ad qui nisi cupidatat voluptate dolor amet eu incididunt.",
    };

    result.push(info1);
    result.push(info2);
    result.push(info3);
    return result;
  };

  return (
    <Row className="main-page-info">
      {info
        ? info.map((item) => <MainPageInfo info={item} key={item.title} />)
        : null}
    </Row>
  );
};

export default MainPageInfoContainer;
