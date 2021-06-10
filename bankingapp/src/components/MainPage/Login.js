import React, { useState } from "react";
import { Form, Button } from "react-bootstrap";
import API from "../../axios/api";

const Login = () => {
  const [login, setLogin] = useState("");
  const [password, setPassword] = useState("");

  const handleLogin = (e) => {
    setLogin(e.target.value);
  };

  const handlePassword = (e) => {
    setPassword(e.target.value);
  };

  const userLogin = (e) => {
    e.preventDefault();
    const data = { login: login, password: password };
    API.post("api/auth/login", data).then((response) => {
      alert(response.data);
    });
  };

  return (
    <div className="login">
      <div className="login-top">
        <h2>Zaloguj się</h2>
        <p>Otwórz konto</p>
      </div>
      <div className="login-form">
        <Form>
          <Form.Group>
            <Form.Label>Numer klienta lub login</Form.Label>
            <Form.Control
              type="text"
              placeholder="Wpisz swój numer klienta lub login"
              value={login}
              onChange={handleLogin}
              autoComplete="false"
            />
          </Form.Group>
          <Form.Group>
            <Form.Label>Hasło</Form.Label>
            <Form.Control
              type="password"
              placeholder="Wpisz swoje hasło"
              autoComplete="false"
              value={password}
              onChange={handlePassword}
            />
          </Form.Group>
          <Form.Group className="login-button-container">
            <Button
              type="submit"
              variant="primary"
              className="login-button"
              onClick={userLogin}
            >
              Zaloguj
            </Button>
          </Form.Group>
        </Form>
      </div>
    </div>
  );
};

export default Login;
