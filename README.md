# UnityQueueManager

A simple queue manager for Unity to executed needed actions in main thread.

Usage:

1. Add component 'QueueManager' to something global, like camera.
2. Add following code to execute your actions:
```
QueueManager.Instance.Enqueue(() => {
 // Do whatever you want!
});
```