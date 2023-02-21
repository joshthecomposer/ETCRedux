<script>
    import {fly , slide} from "svelte/transition";
    const arrows = {
        up : "./img/uparrow.png",
        down: "./img/downarrow.png"
    }
    const WORKOUT = {
        exercise : 5,
        rest : 3,
        sets : 10
    }
    let interval;
    let info;
    let playButton;
    let currentTime = WORKOUT.exercise;
    let show = false;
    let counting = false;
    let activity = 0;
    let sets = WORKOUT.sets;

    function toggleInfo(){
        if (show) {
            show = false;
        } else {
            show=true;
        }
    }

    function activityToggle() {
        if (activity == 0) {
            currentTime = WORKOUT.rest;
            activity = 1;
        } else {
            currentTime = WORKOUT.exercise;
            activity = 0;
        }
    }

    function countDown() {
        if (counting) {
            clearInterval(interval);
            counting = false;
        } else {
            interval = setInterval(() => {
                currentTime--
                if (currentTime < 0) {
                    if (activity == 0) {
                        sets--;
                    }
                    activityToggle();
                }
            }, 1000)
            counting = true;
        }
    }
</script>

<div>
    <div class="timer-card d-flex flex-column justify-content-center align-items-center shadow rounded mx-auto">
        <div class="timer-main d-flex flex-column align-items-center">
            <h1 id="countdown" class="display-1">{currentTime}</h1>
            <h2 id="timer-status">Exercising</h2>
        </div>
        <div class="d-flex flex-column">
            <div class="mx-auto mt-2">
                <p>Sets Remaining: <span id="sets">{sets}</span></p>
            </div>
            <button bind:this="{playButton}" on:click={countDown} class="play-btn mt-2" id="play">{counting ? "Pause" : "Go!"}</button>
            <div>
            <button class="res-btn mt-2">Reset</button>
            </div>
            <hr>
            <div class="d-flex justify-content-center">
                <button class="img-wrapper" on:click={toggleInfo}>
                    <img src="{show ? arrows.up : arrows.down}" class="arrow" alt="Down Arrow" />
                </button>
            </div>
        </div>
    </div>
    {#if show}
        <div bind:this="{info}" in:fly={{duration:200, y:-30}} out:fly={{duration:200, y:-25}} class="info mx-auto mt-4 text-center">
            <h2>Workout Settings</h2>
            <p>Exercise: <span id="exerciseTime">{WORKOUT.exercise}</span></p>
            <p>Rest: <span id="restTime">{WORKOUT.rest}</span></p>
            <p>Total Sets: <span id="sets">{WORKOUT.sets}</span></p>
            <div>
                <button class="btn btn-outline-primary btn-sm">Edit</button>
            </div>
        </div>
    {/if}
</div>
<style>
.timer-card {
    width: 25rem;
}
#countdown {
    font-size: 9rem;
}
.play-btn {
    background-color: green;
    color: white;
    width: 200px;
    height: 40px;
    border-radius: 20px;
    border: 0px;
}
.res-btn {
    background-color: darkred;
    color: white;
    width: 200px;
    height: 40px;
    border-radius: 20px;
    border: 0px;
}
.arrow {
    margin-top: -20px;
    height: 3rem;
    width: 3rem;
}

.img-wrapper {
    border: none;
    background-color: transparent;
}
</style>