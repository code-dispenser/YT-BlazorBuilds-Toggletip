const _handlerMap = new WeakMap<HTMLElement, EventListener>();
const raiseLostFocus = (blazorCallBackRef: any, callBackName: string) => blazorCallBackRef.invokeMethodAsync(callBackName);

function addTabIndexIfScrollableContent(content: HTMLElement) {

    if (!content) return;

    if (content.scrollHeight > content.clientHeight || content.scrollWidth > content.clientWidth) {
        content.setAttribute("tabindex", "0");
    }
    else {
        content.removeAttribute("tabindex");
    }
}
function registerLostFocusHandler(blazorCallBackRef: any, callBackName: string, containerElement: HTMLElement): void {

    if (!containerElement) return;

    const handler = (event: FocusEvent) => {

        if (!containerElement.contains(event.relatedTarget as Node)) {
            raiseLostFocus(blazorCallBackRef, callBackName);
        }
    };

    unRegisterLostFocusHandler(containerElement);

    containerElement.addEventListener("focusout", handler);
    _handlerMap.set(containerElement, handler as EventListener);
  
}
function unRegisterLostFocusHandler(containerElement: HTMLElement): void {

    if (!containerElement) return;

    const handler = _handlerMap.get(containerElement);

    if (handler) {
        containerElement.removeEventListener("focusout", handler);
        _handlerMap.delete(containerElement);                                                                                           
    }
}

export { registerLostFocusHandler, unRegisterLostFocusHandler, addTabIndexIfScrollableContent };