import React, { useState } from 'react'
import { Redirect } from 'react-router-dom'

function LoginForm(props) {
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')
  const [redirect, setRedirect] = useState(false)
  const [role, setRole] = useState('')

  const submit = async (event) => {
    event.preventDefault()

    await fetch(process.env.REACT_APP_API + 'authmanagement/login', {
      method: 'POST',
      headers: {
        Accept: 'application/json',
        'Content-Type': 'application/json',
      },
      credentials: 'include',
      body: JSON.stringify({
        email,
        password,
      }),
    })
      .then((res) => res.json())
      .then(
        (result) => {
          fetch(
            process.env.REACT_APP_API + 'setup/GetUserRoles?email=' + email,
            {
              method: 'GET',
              headers: {
                Accept: '*/*',
              },
              credentials: 'include',
            },
          )
            .then((response) => response.text())
            .then((data) => {
              let role = data.slice(2, data.length - 2)
              setRole(role)
              console.log(role)
              setRedirect(true)
              props.setName(result.userName)
            })
        },
        (error) => {
          alert('Failed')
        },
      )
  }

  if (redirect && role === 'Restorant') {
    return <Redirect to="restorantidashboard" />
  } else if (redirect && role === 'Klient') {
    return <Redirect to="shfletorestorantet" />
  }
  return (
    <div className="d-flex justify-content-center">
      <form onSubmit={submit} autoComplete="off">
        <div className="w-90">
          <h2>Login</h2>

          <div className="form-outline mb-8">
            <input
              type="email"
              id="email"
              className="form-control"
              name="email"
              required
              onChange={(e) => setEmail(e.target.value)}
            />
            <label className="form-label" for="email">
              Email address
            </label>
          </div>

          <div className="form-outline mb-4">
            <input
              type="password"
              id="password"
              className="form-control"
              name="password"
              required
              onChange={(e) => setPassword(e.target.value)}
            />
            <label className="form-label" for="password">
              Password
            </label>
          </div>
          <button
            type="submit"
            value="LOGIN"
            className="btn btn-primary btn-block mb-4"
          >
            Sign in
          </button>
        </div>
      </form>
    </div>
  )
}

export default LoginForm
