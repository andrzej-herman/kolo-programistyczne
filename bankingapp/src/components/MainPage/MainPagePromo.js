import React from "react";
import Promo from "../../images/promo.jpg";
import { Button } from "react-bootstrap";

const MainPagePromo = () => {
  return (
    <div className="main-page-promo">
      <img className="main-page-promo-img" src={Promo} alt="Promo" />
      <div className="main-page-promo-details">
        <h4>Kredyt dla nowych Klientów 0% przez rok !!!</h4>
        <p>
          Super oferta dla nowych osób otwierających konto. Otwór konto, a
          będziesz mógł ciszyć się darmowym kredytem.
        </p>
        <Button variant="danger">Sprawdź szczegóły oferty</Button>
      </div>
    </div>
  );
};

export default MainPagePromo;
