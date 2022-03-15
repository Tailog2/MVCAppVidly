import Navbar from "./Navbar/Navbar";
import 'bootstrap/dist/css/bootstrap-lumen.css'

const Layout = () => {
  const navbarBrandText = "Vidly"

  return (
    <div>
      <header className="App-header">
        <Navbar brandText={navbarBrandText}/>
      </header>  
    </div>
  )
}

export default Layout