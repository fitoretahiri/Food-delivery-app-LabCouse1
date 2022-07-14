import AppNavbar from '../AppNavbar';
import { Outlet } from "react-router-dom";
import { Navbar } from "react-bootstrap";
 
const Layout = (props) => {
    return (  
        <main className="App">
            <AppNavbar setShow={props.setShow} show={props.show} size={props.cart.length} />
            <Outlet />
        </main>
    );
}
 
export default Layout;