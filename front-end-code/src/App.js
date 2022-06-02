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
import RestorantiRegister from './RestorantiRegister';
import KlientiRegister from './KlientiRegister';
import TransportuesiRegister from './TransportuesiRegister'




function App() {
    return (
        <Router>
            <div className="App container">
                    <Switch>
                        <Route exact path="/" component={Home} />
                        <Route path="/restoranti" component={Restoranti} />
                        <Route path="/qyteti" component={Qyteti} />
                        <Route path="/user" component={Useri} />
                        <Route path="/menu" component={Menu}/>
                        <Route path="/role" component={Roli}/>
                        <Route path="/restorantiregister" component={RestorantiRegister}/>
                        <Route path="/klientiregister" component={KlientiRegister}/>
                        <Route path="/transportuesiregister" component={TransportuesiRegister}/>
                    </Switch>
            </div>
        </Router>
    );
}

export default App;

