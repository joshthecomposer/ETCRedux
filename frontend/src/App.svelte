<script>
  import Router from "svelte-spa-router";
  import Home from "./routes/Home.svelte";
  import About from "./routes/About.svelte";
  import Hello from "./routes/Hello.svelte";
  import Navbar from "./Nav.svelte";
  import SignUp from "./routes/SignUp.svelte";
  import NotFound from "./routes/NotFound.svelte";
  let routes = {
    "/": Home,
    "/about": About,
    "/hello" : Hello,
    "/signup" : SignUp,

    "*" : NotFound
  }
</script>

<header>
  <Navbar />
</header>

<main>
  <Router {routes}/>
</main>

<style>
</style>
