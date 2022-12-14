export function callRequestAnimationFrame(instance) {
    window.requestAnimationFrame((timeStamp) => {
        instance.invokeMethodAsync('ViewerRenderLoop', timeStamp);
    });
}