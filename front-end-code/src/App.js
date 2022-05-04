import './App.css';

import {Home} from './Home';
import {Restoranti} from './Restoranti';
import {Navigation} from './Navigation';
import {Qyteti} from './Qyteti';

import {BrowserRouter, Route, Switch} from 'react-router-dom';

function App() {
  return (
    <BrowserRouter>
    <div className="container">
     <h3 className="m-3 d-flex justify-content-center">
       Admin Dashboard
     </h3>

     <Navigation/>

     <Switch>
       <Route path='/' component={Home} exact/>
       <Route path='/Restoranti' component={Restoranti}/>
       <Route path='/Qyteti' component={Qyteti}/>
     </Switch>
    </div>
    </BrowserRouter>
  );
}

export default App;
