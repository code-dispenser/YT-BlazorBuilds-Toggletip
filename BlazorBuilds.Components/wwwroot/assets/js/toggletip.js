const _handlerMap = new WeakMap();
const raiseLostFocus = (blazorCallBackRef, callBackName) => blazorCallBackRef.invokeMethodAsync(callBackName);
function addTabIndexIfScrollableContent(content) {
    if (!content)
        return;
    if (content.scrollHeight > content.clientHeight || content.scrollWidth > content.clientWidth) {
        content.setAttribute("tabindex", "0");
    }
    else {
        content.removeAttribute("tabindex");
    }
}
function registerLostFocusHandler(blazorCallBackRef, callBackName, containerElement) {
    if (!containerElement)
        return;
    const handler = (event) => {
        if (!containerElement.contains(event.relatedTarget)) {
            raiseLostFocus(blazorCallBackRef, callBackName);
        }
    };
    unRegisterLostFocusHandler(containerElement);
    containerElement.addEventListener("focusout", handler);
    _handlerMap.set(containerElement, handler);
}
function unRegisterLostFocusHandler(containerElement) {
    if (!containerElement)
        return;
    const handler = _handlerMap.get(containerElement);
    if (handler) {
        containerElement.removeEventListener("focusout", handler);
        _handlerMap.delete(containerElement);
    }
}
export { registerLostFocusHandler, unRegisterLostFocusHandler, addTabIndexIfScrollableContent };
//# sourceMappingURL=toggletip.js.map