<script>
    async function getHello() {
        const response = await fetch("http://localhost:5076/api/hello")
        const data = await response.json();
        if (response.ok){
            console.log(data)
            return data;
        } else {
            throw new Error(data);
        }
    }
    let promise = getHello();
</script>

{#await promise then hello}
    <h1>{hello.user}</h1>
{/await}