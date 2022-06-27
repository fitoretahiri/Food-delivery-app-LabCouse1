import React from 'react';
import './App.css';
import { useEffect, useState } from "react";

import { Restoranti } from './Restoranti';
import { Qyteti } from './Qyteti';
import { Menu } from './Menu';
import { Roli } from './Roli';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import LoginForm from './LoginForm';
import TransportuesiRegister from './TransportuesiRegister';
import RestorantiRegister from './RestorantiRegister';
import KlientiRegister from './KlientiRegister';
//import { Restaurant_Qyteti } from './Restaurant_Qyteti';
//import { Perdoruesi } from './Perdoruesi';
import DashboardRestoranti from './DashboardRestoranti';
import AppNavbar from './AppNavbar';
import { ShfletoRestaurantet } from './ShfletoRestaurantet';
import { OrderFood } from './OrderFood';
import DashboardKlienti from './DashboardKlienti';
import RestorantetFavorite from './RestorantetFavorite';

//karta
import Cart from './Cart';
import Mesazhet from './Mesazhet';


function App() {
    const [name, setName] = useState('');
    const [show, setShow] = useState(true);
    const [cart, setCart] = useState([]);

    const handleClick = (item) => {
        if(cart.indexOf(item) !== -1) return;
        setCart([...cart, item]);
    }

    const handleChange = (item, d) => {
        const ind = cart.indexOf(item);
        const arr = cart;

        arr[ind].amount += d;

        if(arr[ind].amount === 0) arr[ind].amount = 1;
        setCart([...arr]);
    };

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
    }, [name, cart]);
    
    
    return (
        <Router>
            <div className="App container">
                <AppNavbar name={name} setName={setName} setShow={setShow} show={show} size={cart.length} />
                    <Switch>
                    <Route path="/restaurant" component={Restoranti} />
                    <Route path="/qyteti" component={Qyteti} />
                    <Route path="/menu" component={Menu} />
                    <Route path="/role" component={Roli} />
                    <Route path="/shfletorestorantet" component={ShfletoRestaurantet} />
                    <Route path="/order" component={() => show ? (<OrderFood handleClick={handleClick} />) : (<Cart cart={cart} handleChange={handleChange} setCart={setCart}/>)} />
                    {/*<Route path="/restaurant_qyteti" component={Restaurant_Qyteti} />*/}
                    <Route exact path="/" component={() => <LoginForm setName={setName}/> }/>
                    {/*<Route exact path="perdoruesi" component={Perdoruesi} />*/}
                    <Route path="/klientiregister" component={KlientiRegister} />
                    <Route path="/transportuesiregister" component={TransportuesiRegister} />
                    <Route path="/restorantiregister" component={RestorantiRegister} />
                    <Route path="/restorantidashboard" component={() => <DashboardRestoranti name={name}/>} />
                    <Route path="/klientidashboard" component={() => <DashboardKlienti name={name}/>}/>

                    <Route path="/restorantetfavorite" component={() => <RestorantetFavorite name={name}/>}/>
                    <Route path="/mesazhet" component={Mesazhet}/>
                    
                   

                    </Switch>
            </div>
        </Router>
    );
}

export default App;

