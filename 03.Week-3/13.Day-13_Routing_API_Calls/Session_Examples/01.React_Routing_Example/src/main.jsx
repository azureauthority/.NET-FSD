import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import App from './App.jsx'
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import About from './components/About.jsx';
import Contact from './components/Contact.jsx';
import Navbar from './components/NavBar.jsx';
import Depts from './components/Depts.jsx';
import NotFound from './components/NotFound.jsx';
import Emps from './components/Emps.jsx';
import Details from './components/Details.jsx';


const routing = (
  <Router>  
    <Navbar />
    <Routes>
      <Route path="/"  element={ <App /> } />
      <Route path="/Depts"  element={ <Depts /> } />
      <Route path="/Emps"  element={ <Emps /> } />
      <Route path="/About"  element={ <About /> } />
      <Route path="/Contact"  element={ <Contact /> } />
      <Route path="/Details/:id" element={ <Details /> }  />
      <Route path="*"  element={ <NotFound /> } />
    </Routes>
  </Router>
);

createRoot(document.getElementById('root')).render(
  <StrictMode>
    { routing }
  </StrictMode>
);
