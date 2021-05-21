import React from "react";
import { Form, Button } from "react-bootstrap";

const Login = () => {
  return (
    <div className="login">
      <div className="login-top">
        <h2>Zaloguj się</h2>
        <p>Otwórz konto</p>
      </div>
      <div className="login-form">
        <Form>
          <Form.Group>
            <Form.Label>Numer klienta</Form.Label>
            <Form.Control type="text" placeholder="Wpisz swój numer klienta" />
          </Form.Group>
          <Form.Group>
            <Form.Label>Hasło</Form.Label>
            <Form.Control type="password" placeholder="Wpisz swoje hasło" />
          </Form.Group>
          <Form.Group className="login-button-container">
            <Button variant="primary" className="login-button">Zaloguj</Button>
          </Form.Group>
        </Form>
      </div>
    </div>
  );
};

export default Login;
