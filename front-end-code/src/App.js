import React from 'react';
import './App.css';
import { useEffect, useState } from "react";

import { Restoranti } from './Restoranti';
import { Qyteti } from './Qyteti';
import { Menu } from './Menu';
import { Roli } from './Roli/Roli';
import { UserRole } from './User-Role/UserRole';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import LoginForm from './LoginForm';
import TransportuesiRegister from './TransportuesiRegister';
import RestorantiRegister from './RestorantiRegister';
import KlientiRegister from './KlientiRegister';
import { Restaurant_Qyteti } from './Restaurant_Qyteti';
//import { Perdoruesi } from './Perdoruesi';
import DashboardRestoranti from './DashboardRestoranti';
import AppNavbar from './AppNavbar';
import { ShfletoRestaurantet } from './ShfletoRestaurantet';
import { OrderFood } from './OrderFood';
import { Pija } from './Pija';
import { Ushqimi } from './Ushqimi';
import { User } from './Users/User';
import Pagesa from './Pagesa';
import { Pagesa2 } from './Pagesa/Pagesa2';



function App() {
    const [name, setName] = useState('');
    useEffect(()=>{
        (
            async () => {
                const response = await fetch(process.env.REACT_APP_API+'authmanagement/user',{
                    headers:{
                        'Accept':'application/json',
                        'Content-Type':'application/json'
                    },
                    credentials: 'include'
                });

                const content = await response.json();
                setName(content.userName);
            }
        )()
    }, [name]);
    
    
    return (
        <Router>
            <div className="App container">
                <AppNavbar name={name} setName={setName}/>
                    <Switch>
                    <Route path="/restaurant" component={Restoranti} />
                    <Route path="/qyteti" component={Qyteti} />
                    <Route path="/menu" component={Menu} />
                    <Route path="/role" component={Roli} />
                    <Route path="/users" component={User} />
                    <Route path="/userrole" component={UserRole} />
                    <Route path="/roles" component={Roli} />
                    <Route path="/shfletorestorantet" component={ShfletoRestaurantet} />
                    <Route path="/order" component={OrderFood} />
                    <Route path="/restaurant_qyteti" component={Restaurant_Qyteti} />
                    <Route exact path="/" component={() => <LoginForm setName={setName}/>} />
                    {/*<Route exact path="perdoruesi" component={Perdoruesi} />*/}
                    <Route path="/klientiregister" component={KlientiRegister} />
                    <Route path="/transportuesiregister" component={TransportuesiRegister} />
                    <Route path="/restorantiregister" component={RestorantiRegister} />
                    <Route path="/pija" component={Pija} />
                    <Route path="/ushqimi" component={Ushqimi} />
                    <Route path="/pagesa" component={Pagesa} />
                    <Route path="/pagesaDashboard" component={Pagesa2} />
                    <Route path="/restorantidashboard" component={() => <DashboardRestoranti name={name}/>} />
                    </Switch>
            </div>
        </Router>
    );
}

export default App;

