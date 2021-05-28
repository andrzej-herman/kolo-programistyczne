import React from "react";
import "../components/MainPage/MainPage.css";
import { Container, Button } from "react-bootstrap";
import MainPageHeader from "../components/MainPage/MainPageHeader";
import MainPageInfoContainer from "../components/MainPage/MainPageInfoContainer";
import HorizontalDivider from "../components/Common/HorizontalDivider";
import { Link } from "react-router-dom";

const CreditInfoPage = () => {
  return (
    <Container>
      <MainPageHeader />
      <div className="credit-promo">
        <h2>Informacje o kredycie 0%</h2>
        <p>
          <br />
          Sit eu eu elit cupidatat velit non est. Minim aliquip incididunt
          incididunt consequat sit enim. Pariatur amet ut laborum incididunt
          dolore nulla elit amet minim mollit. Laborum in magna quis fugiat
          nostrud deserunt nulla quis nulla sit. Id velit dolore quis pariatur
          consequat culpa cillum commodo aliquip. Ad ipsum voluptate duis culpa
          minim mollit ipsum Lorem cupidatat commodo fugiat commodo. Commodo
          adipisicing laborum proident eu non. <br />
          <br />
          In voluptate ex eiusmod veniam laborum magna cillum id ex cillum culpa
          esse excepteur incididunt. Aute mollit excepteur pariatur voluptate
          dolore ullamco est. Duis voluptate nisi deserunt officia nostrud esse
          labore officia. Duis consectetur adipisicing in reprehenderit laborum
          eu nulla id nostrud consectetur dolore laboris nulla adipisicing. Et
          velit occaecat magna tempor proident qui adipisicing ipsum cupidatat
          cillum. Sit sit aliqua cillum aute deserunt elit reprehenderit
          reprehenderit. Lorem voluptate sint ad adipisicing anim sint elit
          reprehenderit laboris sunt elit. Laborum consectetur nisi ex aliquip
          officia ipsum dolore commodo culpa dolore et ullamco. <br />
          <br />
          Esse officia culpa officia veniam nostrud ex nulla veniam elit minim
          voluptate. Aliqua aliquip laborum ullamco nulla in non. Magna eiusmod
          pariatur cupidatat quis commodo quis. Enim ipsum officia exercitation
          consequat nostrud esse nostrud irure nostrud cillum est. Ex sint Lorem
          ipsum eiusmod irure aute voluptate elit ea labore labore.
        </p>
        <Link to="/">
          <Button variant="primary">Powrót na stronę główną</Button>
        </Link>
      </div>

      <HorizontalDivider />
      <MainPageInfoContainer />
    </Container>
  );
};

export default CreditInfoPage;
