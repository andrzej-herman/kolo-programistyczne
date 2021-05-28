import React from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import CreditInfoPage from "./pages/CreditInfoPage";
import MainPage from "./pages/MainPage";

const App = () => {
  return (
    <Router>
      <Switch>
        <Route exact path="/" component={MainPage} />
        <Route exact path="/promo-credit" component={CreditInfoPage} />
      </Switch>
    </Router>
  );
};

export default App;
