https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-based-asynchronous-programming

Composing tasks
The Task and Task<TResult> classes provide several methods that can help you compose multiple tasks to implement common patterns and to better use the asynchronous language features that are provided by C#, Visual Basic, and F#. This section describes the WhenAll, WhenAny, Delay, and FromResult methods.

Task.WhenAll
The Task.WhenAll method asynchronously waits for multiple Task or Task<TResult> objects to finish. It provides overloaded versions that enable you to wait for non-uniform sets of tasks. For example, you can wait for multiple Task and Task<TResult> objects to complete from one method call.

Task.WhenAny
The Task.WhenAny method asynchronously waits for one of multiple Task or Task<TResult> objects to finish. As in the Task.WhenAll method, this method provides overloaded versions that enable you to wait for non-uniform sets of tasks. The WhenAny method is especially useful in the following scenarios.

Redundant operations. Consider an algorithm or operation that can be performed in many ways. You can use the WhenAny method to select the operation that finishes first and then cancel the remaining operations.

Interleaved operations. You can start multiple operations that must all finish and use the WhenAny method to process results as each operation finishes. After one operation finishes, you can start one or more additional tasks.

Throttled operations. You can use the WhenAny method to extend the previous scenario by limiting the number of concurrent operations.

Expired operations. You can use the WhenAny method to select between one or more tasks and a task that finishes after a specific time, such as a task that is returned by the Delay method. The Delay method is described in the following section.

Task.Delay
The Task.Delay method produces a Task object that finishes after the specified time. You can use this method to build loops that occasionally poll for data, introduce time-outs, delay the handling of user input for a predetermined time, and so on.

Task(T).FromResult
By using the Task.FromResult method, you can create a Task<TResult> object that holds a pre-computed result. This method is useful when you perform an asynchronous operation that returns a Task<TResult> object, and the result of that Task<TResult> object is already computed. For an example that uses FromResult to retrieve the results of asynchronous download operations that are held in a cache, see How to: Create Pre-Computed Tasks.

Handling exceptions in tasks
When a task throws one or more exceptions, the exceptions are wrapped in an AggregateException exception. That exception is propagated back to the thread that joins with the task, which is typically the thread that is waiting for the task to finish or the thread that accesses the Result property. This behavior serves to enforce the .NET Framework policy that all unhandled exceptions by default should terminate the process. The calling code can handle the exceptions by using any of the following in a try/catch block:

The Wait method

The WaitAll method

The WaitAny method

The Result property

The joining thread can also handle exceptions by accessing the Exception property before the task is garbage-collected. By accessing this property, you prevent the unhandled exception from triggering the exception propagation behavior that terminates the process when the object is finalized.

For more information about exceptions and tasks, see Exception Handling.

Canceling tasks
The Task class supports cooperative cancellation and is fully integrated with the System.Threading.CancellationTokenSource and System.Threading.CancellationToken classes, which were introduced in the .NET Framework 4. Many of the constructors in the System.Threading.Tasks.Task class take a CancellationToken object as an input parameter. Many of the StartNew and Run overloads also include a CancellationToken parameter.

You can create the token, and issue the cancellation request at some later time, by using the CancellationTokenSource class. Pass the token to the Task as an argument, and also reference the same token in your user delegate, which does the work of responding to a cancellation request.

For more information, see Task Cancellation and How to: Cancel a Task and Its Children.

The TaskFactory class
The TaskFactory class provides static methods that encapsulate some common patterns for creating and starting tasks and continuation tasks.

The most common pattern is StartNew, which creates and starts a task in one statement.

When you create continuation tasks from multiple antecedents, use the ContinueWhenAll method or ContinueWhenAny method or their equivalents in the Task<TResult> class. For more information, see Chaining Tasks by Using Continuation Tasks.

To encapsulate Asynchronous Programming Model BeginX and EndX methods in a Task or Task<TResult> instance, use the FromAsync methods. For more information, see TPL and Traditional .NET Framework Asynchronous Programming.

The default TaskFactory can be accessed as a static property on the Task class or Task<TResult> class. You can also instantiate a TaskFactory directly and specify various options that include a CancellationToken, a TaskCreationOptions option, a TaskContinuationOptions option, or a TaskScheduler. Whatever options are specified when you create the task factory will be applied to all tasks that it creates, unless the Task is created by using the TaskCreationOptions enumeration, in which case the task's options override those of the task factory.

Tasks without delegates
In some cases, you may want to use a Task to encapsulate some asynchronous operation that is performed by an external component instead of your own user delegate. If the operation is based on the Asynchronous Programming Model Begin/End pattern, you can use the FromAsync methods. If that is not the case, you can use the TaskCompletionSource<TResult> object to wrap the operation in a task and thereby gain some of the benefits of Task programmability, for example, support for exception propagation and continuations. For more information, see TaskCompletionSource<TResult>.

Custom schedulers
Most application or library developers do not care which processor the task runs on, how it synchronizes its work with other tasks, or how it is scheduled on the System.Threading.ThreadPool. They only require that it execute as efficiently as possible on the host computer. If you require more fine-grained control over the scheduling details, the Task Parallel Library lets you configure some settings on the default task scheduler, and even lets you supply a custom scheduler. For more information, see TaskScheduler.

Related data structures
The TPL has several new public types that are useful in both parallel and sequential scenarios. These include several thread-safe, fast and scalable collection classes in the System.Collections.Concurrent namespace, and several new synchronization types, for example, System.Threading.Semaphore and System.Threading.ManualResetEventSlim, which are more efficient than their predecessors for specific kinds of workloads. Other new types in the .NET Framework 4, for example, System.Threading.Barrier and System.Threading.SpinLock, provide functionality that was not available in earlier releases. For more information, see Data Structures for Parallel Programming.

Custom task types
We recommend that you do not inherit from System.Threading.Tasks.Task or System.Threading.Tasks.Task<TResult>. Instead, we recommend that you use the AsyncState property to associate additional data or state with a Task or Task<TResult> object. You can also use extension methods to extend the functionality of the Task and Task<TResult> classes. For more information about extension methods, see Extension Methods and Extension Methods.

If you must inherit from Task or Task<TResult>, you cannot use Run, Run, or the System.Threading.Tasks.TaskFactory, System.Threading.Tasks.TaskFactory<TResult>, or System.Threading.Tasks.TaskCompletionSource<TResult> classes to create instances of your custom task type because these mechanisms create only Task and Task<TResult> objects. In addition, you cannot use the task continuation mechanisms that are provided by Task, Task<TResult>, TaskFactory, and TaskFactory<TResult> to create instances of your custom task type because these mechanisms also create only Task and Task<TResult> objects.
