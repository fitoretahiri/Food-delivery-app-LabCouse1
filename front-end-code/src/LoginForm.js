import React, { useState } from 'react'

function LoginForm({ Login, error }) {
    const [details, setDetails] = useState({ name: "", email: "", password: "" });
    const submitHandler = e => {
        e.preventDefault();
        Login(details);
    }
    return (
        <div className="d-flex justify-content-center">
            <form onSubmit={submitHandler}>
                <div className="w-90">
                    <h2>Login</h2>
                    {(error != "") ? (<div className='error'>{error}</div>) : ""}
  
                    <div className="form-outline mb-8">
                        <input type="email" id="email" className="form-control" />
                        <label className="form-label" for="email">Email address</label>
                    </div>

                    <div className="form-outline mb-4">
                        <input type="password" id="password" className="form-control" />
                        <label className="form-label" for="password">Password</label>
                    </div>

                    <div className="row mb-4">
                        <div className="col d-flex justify-content-center">
                            <div className="form-check">
                                <input className="form-check-input" type="checkbox" value="" id="checkbox" checked />
                                <label className="form-check-label"> Remember me </label>
                            </div>
                        </div>

                        <div className="col">
                            <a href="#!">Forgot password?</a>
                        </div>
                    </div>

                    <button type="submit" value="LOGIN" class="btn btn-primary btn-block mb-4">Sign in</button>


                    <div className="text-center">
                        <p>Not a member? <a href="#!">Register</a></p>
                        <p>or sign up with:</p>
                        <button type="button" className="btn btn-link btn-floating mx-1">
                            <i className="fab fa-facebook-f"></i>
                        </button>

                        <button type="button" className="btn btn-link btn-floating mx-1">
                            <i className="fab fa-google"></i>
                        </button>

                        <button type="button" className="btn btn-link btn-floating mx-1">
                            <i className="fab fa-twitter"></i>
                        </button>

                        <button type="button" className="btn btn-link btn-floating mx-1">
                            <i className="fab fa-github"></i>
                        </button>
                    </div>
                </div>
            </form>
        </div>
    )
}

export default LoginForm;