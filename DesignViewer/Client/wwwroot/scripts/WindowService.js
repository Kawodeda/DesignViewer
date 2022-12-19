export function addWindowResizedListener(listener) {
    window.addEventListener("resize", () => {
        listener.invokeMethodAsync("OnWindowResized", window.innerWidth, window.innerHeight);
    });
}

export function getWindowWidth() {
    return window.innerWidth;
}

export function getWindowHeight() {
    return window.innerHeight;
}