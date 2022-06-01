import React from 'react';
import './App.css';

import { Home } from './Home';
import { Restoranti } from './Restoranti';
import { Navigation } from './Navigation';
import { Qyteti } from './Qyteti';
import { Useri } from './Useri';
import { Menu } from './Menu';
import { Roli } from './Roli';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';




function App() {
    return (
        <Router>
            <div className="App container">
                <Navigation />
                    <Switch>
                        <Route exact path="/" component={Home} />
                        <Route path="/restoranti" component={Restoranti} />
                        <Route path="/qyteti" component={Qyteti} />
                        <Route path="/user" component={Useri} />
                        <Route path="/menu" component={Menu}/>
                        <Route path="/role" component={Roli}/>
                    </Switch>
            </div>
        </Router>
    );
}

export default App;

