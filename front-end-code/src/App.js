import React from 'react';
import './App.css';

import { Restoranti } from './Restoranti';
import { Qyteti } from './Qyteti';
import { Menu } from './Menu';
import { Roli } from './Roli';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import LoginForm from './LoginForm';
import { TransportuesiRegister } from './TransportuesiRegister';
import { Restaurant_Qyteti } from './Restaurant_Qyteti';
import { Perdoruesi } from './Perdoruesi';
import RestorantiRegister from './RestorantiRegister';
<<<<<<< HEAD
import { ShfletoRestaurantet } from './ShfletoRestaurantet';
import { OrderFood } from './OrderFood';
import { Ushqimi } from './Ushqimi';
import { Pija } from './Pija';
=======
>>>>>>> login_functionality_branch



function App() {
    return (
        <Router>
            <div className="App container">
                    <Switch>
                    <Route path="/restaurant" component={Restoranti} />
<<<<<<< HEAD
                    <Route path="/pija" component={Pija} />
                    <Route path="/ushqimi" component={Ushqimi} />
=======
>>>>>>> login_functionality_branch
                    <Route path="/qyteti" component={Qyteti} />
                    <Route path="/menu" component={Menu} />
                    <Route path="/role" component={Roli} />
                    <Route path="/restaurant_qyteti" component={Restaurant_Qyteti} />
                    <Route exact path="/" component={LoginForm} />
                    <Route exact path="perdoruesi" component={Perdoruesi} />
                    <Route path="/transportuesiregister" component={TransportuesiRegister} />
                    <Route path="/restorantiregister" component={RestorantiRegister} />
<<<<<<< HEAD
                    <Route path="/shfletorestorantet" component={ShfletoRestaurantet} />
                    <Route path="/order" component={OrderFood} />

=======
>>>>>>> login_functionality_branch
                    </Switch>
            </div>
        </Router>
    );
}

export default App;

