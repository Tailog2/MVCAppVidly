import 'bootstrap/dist/css/bootstrap-lumen.css'
import {Styles} from "./Styles";

const Footer = () => {
  return (
    <>
      <footer class="border-top text-muted" style={Styles.Footer}>
        <div class="container">
            &copy; 2022 - Vidly - <a>Privacy</a>
        </div>
      </footer>
    </>
  )
}

export default Footer