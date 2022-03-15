import Layout from "./Components/Layout";
import Index from "./Home/Index";
import Footer from "./Components/Footer";
import 'bootstrap/dist/css/bootstrap-lumen.css'
import 'wwwroot/css/site.css'

function App() {
  return (
    <div className="App">      
        <Layout />
        <div class="container">
          <main role="main" class="pb-3">
            <Index />
          </main>
        </div>      
        <Footer />
        <script src="~wwwroot/lib/jquery/dist/jquery.min.js"></script>
        <script src="~wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
        <script src="~wwwroot/js/site.js"></script>
    </div>
  );
}

export default App;
