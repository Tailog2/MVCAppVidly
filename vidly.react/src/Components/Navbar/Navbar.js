import NavButtons from "./NavButtons"
import 'bootstrap/dist/css/bootstrap-lumen.css'

const Navbar = ({brandText}) => {
  return (
    <div>
        <header>
            <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3">
                <div class="container-fluid">
                    <a class="navbar-brand">{brandText}</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" aria-controls="navbarSupportedContent"
                            aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>         
                    <NavButtons />         
                </div>      
            </nav>
        </header>
    </div>
  )
}

export default Navbar