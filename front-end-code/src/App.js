import React from 'react';
import './App.css';

import { Restoranti } from './Restoranti';
import { Qyteti } from './Qyteti';
import { Useri } from './Useri';
import { Menu } from './Menu';
import { Roli } from './Roli';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
<<<<<<< Updated upstream
import RestorantiRegister from './RestorantiRegister';
import KlientiRegister from './KlientiRegister';
import TransportuesiRegister from './TransportuesiRegister'

=======
import LoginForm from './LoginForm';
>>>>>>> Stashed changes



function App() {
    return (
        <Router>
            <div className="App container">
                    <Switch>
                        <Route path="/restoranti" component={Restoranti} />
                        <Route path="/qyteti" component={Qyteti} />
                        <Route path="/user" component={Useri} />
<<<<<<< Updated upstream
                        <Route path="/menu" component={Menu}/>
                        <Route path="/role" component={Roli}/>
                        <Route path="/restorantiregister" component={RestorantiRegister}/>
                        <Route path="/klientiregister" component={KlientiRegister}/>
                        <Route path="/transportuesiregister" component={TransportuesiRegister}/>
=======
                    <Route path="/menu" component={Menu} />
                    <Route path="/role" component={Roli} />
                    <Route path="/" component={LoginForm}/>
>>>>>>> Stashed changes
                    </Switch>
            </div>
        </Router>
    );
}

export default App;

