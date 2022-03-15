import 'bootstrap/dist/css/bootstrap-lumen.css'

const LoginParial = () => {
  return (
    <>
        <ul class="navbar-nav"> 
        <li class="nav-item">
                <a class="nav-link text-dark" asp-area="Identity" asp-page="/Account/Register">Register</a>
            </li>
            <li class="nav-item">
                <a class="nav-link text-dark" asp-area="Identity" asp-page="/Account/Login">Login</a>
            </li>
        </ul>
    </>
  )
}

export default LoginParial