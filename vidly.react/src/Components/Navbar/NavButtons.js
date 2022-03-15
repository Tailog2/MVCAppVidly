import HomeButton from "./Buttons/HomeButton"
import CustomersButton from "./Buttons/CustomersButton"
import MoviesButton from "./Buttons/MoviesButton"
import PrivacyButton from "./Buttons/PrivacyButton"
import 'bootstrap/dist/css/bootstrap-lumen.css'
import LoginParial from "./LoginParial"

const NavButtons = () => {
    const homeButtonText = "Home"
    const customersButtonText = "Customers"
    const moviesButtonText = "Movies"
    const privacyButtonText = "Privacy"

    return (
        <>
            <div class="navbar-collapse collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    <li class="nav-item">
                        <HomeButton text={homeButtonText} />
                    </li>
                    <li class="nav-item">
                        <CustomersButton text={customersButtonText} />
                    </li>
                    <li class="nav-item">
                        <MoviesButton text={moviesButtonText} />
                    </li>
                    <li class="nav-item">
                        <PrivacyButton text={privacyButtonText} />
                    </li>
                </ul>
                <LoginParial />
            </div>
        </>
    )
}

export default NavButtons