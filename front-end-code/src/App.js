import React from 'react';
import './App.css';

import { Restoranti } from './Restoranti';
import { Qyteti } from './Qyteti';
import { Useri } from './Useri';
import { Menu } from './Menu';
import { Roli } from './Roli';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import LoginForm from './LoginForm';



function App() {
    return (
        <Router>
            <div className="App container">
                    <Switch>
                        <Route path="/restoranti" component={Restoranti} />
                        <Route path="/qyteti" component={Qyteti} />
                        <Route path="/user" component={Useri} />
                    <Route path="/menu" component={Menu} />
                    <Route path="/role" component={Roli} />
                    <Route path="/" component={LoginForm}/>
                    </Switch>
            </div>
        </Router>
    );
}

export default App;

