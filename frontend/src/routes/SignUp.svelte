<script>
    let user = {
        FirstName : "",
        LastName : "",
        Email : "",
        Password : "",
        Confirm : ""
    }

    function sendForm() {
        
    }
</script>

<div class="container shadow rounded p-5 form-card">
    <h1>Sign Up</h1>
    <hr>
    <form>
        <div class="form-group">
            <label for="First Name">First Name</label>
            <input class="form-control" type="text" bind:value={user.FirstName}>
        </div>
        <div class="form-group">
            <label for="Last Name">Last Name</label>
            <input class="form-control" type="text" bind:value={user.LastName}>
        </div>
        <div class="form-group">
            <label for="Email">Email</label>
            <input class="form-control" type="text" bind:value={user.FirstName}>
        </div>
        <div class="form-group">
            <label for="Password">Password</label>
            <input class="form-control" type="password" bind:value={user.Password}>
        </div>
        <div class="form-group">
            <label for="Confirm">Confirm</label>
            <input class="form-control" type="password" bind:value={user.Confirm}>
        </div>
        <button type="button" class="btn btn-outline-primary col-12 mt-4" on:click={sendForm}>Submit</button>
    </form>
</div>

<style>
    .form-card {
        width: 25rem;
    }
</style>