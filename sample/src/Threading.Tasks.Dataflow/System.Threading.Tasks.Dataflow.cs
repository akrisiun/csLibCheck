
namespace System.Threading.Tasks.Dataflow
{  


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("cae8c8ba-a95e-3318-9fea-008f0169bb96")]
  public abstract sealed class DataflowBlock : System.Object
{
    public static IDisposable LinkTo(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, ITargetBlock<System.Threading.Tasks.Dataflow.TOutput> target) { throw new NotImplementedException(); }
    public static IDisposable LinkTo(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, ITargetBlock<System.Threading.Tasks.Dataflow.TOutput> target, Predicate<System.Threading.Tasks.Dataflow.TOutput> predicate) { throw new NotImplementedException(); }
    public static IDisposable LinkTo(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, ITargetBlock<System.Threading.Tasks.Dataflow.TOutput> target, DataflowLinkOptions linkOptions, Predicate<System.Threading.Tasks.Dataflow.TOutput> predicate) { throw new NotImplementedException(); }
    public static bool Post(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.TInput> target, TInput item) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<bool> SendAsync(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.TInput> target, TInput item) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<bool> SendAsync(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.TInput> target, TInput item, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static bool TryReceive(System.Threading.Tasks.Dataflow.IReceivableSourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, out TOutput item) { throw new NotImplementedException(); }
    public static ReceiveAsync(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source) { throw new NotImplementedException(); }
    public static ReceiveAsync(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static ReceiveAsync(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, TimeSpan timeout) { throw new NotImplementedException(); }
    public static ReceiveAsync(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static Receive(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source) { throw new NotImplementedException(); }
    public static Receive(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static Receive(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, TimeSpan timeout) { throw new NotImplementedException(); }
    public static Receive(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<bool> OutputAvailableAsync(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<bool> OutputAvailableAsync(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static Encapsulate(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.TInput> target, ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<int> Choose(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.T1> source1, Action<System.Threading.Tasks.Dataflow.T1> action1, ISourceBlock<System.Threading.Tasks.Dataflow.T2> source2, Action<System.Threading.Tasks.Dataflow.T2> action2) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<int> Choose(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.T1> source1, Action<System.Threading.Tasks.Dataflow.T1> action1, ISourceBlock<System.Threading.Tasks.Dataflow.T2> source2, Action<System.Threading.Tasks.Dataflow.T2> action2, DataflowBlockOptions dataflowBlockOptions) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<int> Choose(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.T1> source1, Action<System.Threading.Tasks.Dataflow.T1> action1, ISourceBlock<System.Threading.Tasks.Dataflow.T2> source2, Action<System.Threading.Tasks.Dataflow.T2> action2, ISourceBlock<System.Threading.Tasks.Dataflow.T3> source3, Action<System.Threading.Tasks.Dataflow.T3> action3) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<int> Choose(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.T1> source1, Action<System.Threading.Tasks.Dataflow.T1> action1, ISourceBlock<System.Threading.Tasks.Dataflow.T2> source2, Action<System.Threading.Tasks.Dataflow.T2> action2, ISourceBlock<System.Threading.Tasks.Dataflow.T3> source3, Action<System.Threading.Tasks.Dataflow.T3> action3, DataflowBlockOptions dataflowBlockOptions) { throw new NotImplementedException(); }
    public static AsObservable(System.Threading.Tasks.Dataflow.ISourceBlock<System.Threading.Tasks.Dataflow.TOutput> source) { throw new NotImplementedException(); }
    public static AsObserver(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.TInput> target) { throw new NotImplementedException(); }
    public static NullTarget() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("1817b58d-b66a-3d2f-ba45-39ce8815aa94")]
  public class DataflowBlockOptions : System.Object
{
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public DataflowBlockOptions () {}
   public System.Threading.Tasks.TaskScheduler TaskScheduler { get; set; }
   public System.Threading.CancellationToken CancellationToken { get; set; }
   public int MaxMessagesPerTask { get; set; }
   public int BoundedCapacity { get; set; }
   public string NameFormat { get; set; }
   public bool EnsureOrdered { get; set; }
// Field: 
public static const int Unbounded = -1;
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("35012b47-b707-3963-b8ad-8da3e9969a76")]
  public class ExecutionDataflowBlockOptions : DataflowBlockOptions
{
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public ExecutionDataflowBlockOptions () {}
   public int MaxDegreeOfParallelism { get; set; }
   public bool SingleProducerConstrained { get; set; }
   public System.Threading.Tasks.TaskScheduler TaskScheduler { get; set; }
   public System.Threading.CancellationToken CancellationToken { get; set; }
   public int MaxMessagesPerTask { get; set; }
   public int BoundedCapacity { get; set; }
   public string NameFormat { get; set; }
   public bool EnsureOrdered { get; set; }
// Field: 
public static const int Unbounded = -1;
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("089c9b54-7cfc-3a57-9c92-10e43f9e5a8a")]
  public class GroupingDataflowBlockOptions : DataflowBlockOptions
{
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public GroupingDataflowBlockOptions () {}
   public bool Greedy { get; set; }
   public long MaxNumberOfGroups { get; set; }
   public System.Threading.Tasks.TaskScheduler TaskScheduler { get; set; }
   public System.Threading.CancellationToken CancellationToken { get; set; }
   public int MaxMessagesPerTask { get; set; }
   public int BoundedCapacity { get; set; }
   public string NameFormat { get; set; }
   public bool EnsureOrdered { get; set; }
// Field: 
public static const int Unbounded = -1;
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("dfd9d80e-94d1-3575-8dbf-39bb82371e0d")]
  public class DataflowLinkOptions : System.Object
{
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public DataflowLinkOptions () {}
   public bool PropagateCompletion { get; set; }
   public int MaxMessages { get; set; }
   public bool Append { get; set; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("876e8921-0a02-3cea-b675-36c529033558")]
  public sealed struct DataflowMessageHeader : System.ValueType System.IEquatable<System.Threading.Tasks.Dataflow.DataflowMessageHeader>
{
    public virtual bool Equals(System.Threading.Tasks.Dataflow.DataflowMessageHeader other) { throw new NotImplementedException(); }
    public override bool Equals(object obj) { throw new NotImplementedException(); }
    public override int GetHashCode() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public DataflowMessageHeader (long id) {}
   public bool IsValid { get; }
   public long Id { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("437dea44-21f4-34e6-852a-d42494896cd7")]
  public sealed enum DataflowMessageStatus : System.Enum
{
    public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("e1bd6ca2-ca92-3066-abaf-1a792727fc4a")]
  public interface IDataflowBlock
{
    void Complete() {}
    void Fault(Exception exception) {}
   public System.Threading.Tasks.Task Completion { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("78ebd1af-0468-358a-b2e7-fd79469b946b")]
  public interface IPropagatorBlock`2 : ITargetBlock<System.Threading.Tasks.Dataflow.TInput>, ISourceBlock<System.Threading.Tasks.Dataflow.TOutput>
{
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("0ea62736-976e-31e6-9472-159adf33c413")]
  public interface IReceivableSourceBlock`1 : ISourceBlock<System.Threading.Tasks.Dataflow.TOutput>
{
    bool TryReceive(Predicate<System.Threading.Tasks.Dataflow.TOutput> filter, out TOutput item) { throw new NotImplementedException(); }
    bool TryReceiveAll(out System.Collections.Generic.IList`1 items) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("e986232a-4388-39df-ac79-96b754e76439")]
  public interface ISourceBlock`1 : IDataflowBlock
{
    IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.TOutput> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, ITargetBlock<System.Threading.Tasks.Dataflow.TOutput> target, out bool messageConsumed) { throw new NotImplementedException(); }
    bool ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, ITargetBlock<System.Threading.Tasks.Dataflow.TOutput> target) { throw new NotImplementedException(); }
    void ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, ITargetBlock<System.Threading.Tasks.Dataflow.TOutput> target) {}
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("e4e18fdc-aef4-309d-a150-4b9e171dcf79")]
  public interface ITargetBlock`1 : IDataflowBlock
{
    DataflowMessageStatus OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<System.Threading.Tasks.Dataflow.TInput> source, bool consumeToAccept) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("b08580c0-0b9e-341e-b117-d16aa00ba932")]
  public sealed class ActionBlock`1 : System.Object ITargetBlock<System.Threading.Tasks.Dataflow.TInput>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public bool Post(System.Threading.Tasks.Dataflow.TInput item) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public ActionBlock<TInput> (Action<System.Threading.Tasks.Dataflow.TInput> action) {}
//ctor: 
public ActionBlock<TInput> (Action<System.Threading.Tasks.Dataflow.TInput> action, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
//ctor: 
public ActionBlock<TInput> (Func<System.Threading.Tasks.Dataflow.TInput,System.Threading.Tasks.Task> action) {}
//ctor: 
public ActionBlock<TInput> (Func<System.Threading.Tasks.Dataflow.TInput,System.Threading.Tasks.Task> action, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
   public virtual System.Threading.Tasks.Task Completion { get; }
   public int InputCount { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("b346466d-3c48-3b46-af57-87ae4f3e8119")]
  public sealed class BatchBlock`1 : System.Object IPropagatorBlock<System.Threading.Tasks.Dataflow.T,System.Threading.Tasks.Dataflow.T[]>, IReceivableSourceBlock<System.Threading.Tasks.Dataflow.T[]>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public void TriggerBatch() {}
    public virtual IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.T[]> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<System.Threading.Tasks.Dataflow.T[]> filter, out T[] item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList`1 items) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public BatchBlock<T> (int batchSize) {}
//ctor: 
public BatchBlock<T> (int batchSize, GroupingDataflowBlockOptions dataflowBlockOptions) {}
   public int OutputCount { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
   public int BatchSize { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("44e7eb60-d4df-3624-8ffe-fae45a7eb0eb")]
  public sealed class BatchedJoinBlock`2 : System.Object IReceivableSourceBlock<System.Tuple>, Internal.IDebuggerDisplay
{
    public virtual IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<Tuple> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<Tuple> filter, out Tuple`2 item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList`1 items) { throw new NotImplementedException(); }
    public virtual void Complete() {}
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public BatchedJoinBlock<T1,T2> (int batchSize) {}
//ctor: 
public BatchedJoinBlock<T1,T2> (int batchSize, GroupingDataflowBlockOptions dataflowBlockOptions) {}
   public int BatchSize { get; }
   public ITargetBlock<System.Threading.Tasks.Dataflow.T1> Target1 { get; }
   public ITargetBlock<System.Threading.Tasks.Dataflow.T2> Target2 { get; }
   public int OutputCount { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("d0751974-ed58-31b7-bdc1-4c5705794bc9")]
  public sealed class BatchedJoinBlock`3 : System.Object IReceivableSourceBlock<System.Tuple>, Internal.IDebuggerDisplay
{
    public virtual IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<Tuple> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<Tuple> filter, out Tuple`3 item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList`1 items) { throw new NotImplementedException(); }
    public virtual void Complete() {}
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public BatchedJoinBlock<T1,T2,T3> (int batchSize) {}
//ctor: 
public BatchedJoinBlock<T1,T2,T3> (int batchSize, GroupingDataflowBlockOptions dataflowBlockOptions) {}
   public int BatchSize { get; }
   public ITargetBlock<System.Threading.Tasks.Dataflow.T1> Target1 { get; }
   public ITargetBlock<System.Threading.Tasks.Dataflow.T2> Target2 { get; }
   public ITargetBlock<System.Threading.Tasks.Dataflow.T3> Target3 { get; }
   public int OutputCount { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("17d9f543-aac8-3b38-88cd-b796f1d5af79")]
  public sealed class BroadcastBlock`1 : System.Object IPropagatorBlock<System.Threading.Tasks.Dataflow.T,System.Threading.Tasks.Dataflow.T>, IReceivableSourceBlock<System.Threading.Tasks.Dataflow.T>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public virtual IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.T> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<System.Threading.Tasks.Dataflow.T> filter, out T item) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public BroadcastBlock<T> (Func<System.Threading.Tasks.Dataflow.T,System.Threading.Tasks.Dataflow.T> cloningFunction) {}
//ctor: 
public BroadcastBlock<T> (Func<System.Threading.Tasks.Dataflow.T,System.Threading.Tasks.Dataflow.T> cloningFunction, DataflowBlockOptions dataflowBlockOptions) {}
   public virtual System.Threading.Tasks.Task Completion { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("43c2f03a-2f94-3de6-b639-c39d572e3acb")]
  public sealed class BufferBlock`1 : System.Object IPropagatorBlock<System.Threading.Tasks.Dataflow.T,System.Threading.Tasks.Dataflow.T>, IReceivableSourceBlock<System.Threading.Tasks.Dataflow.T>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public virtual IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.T> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<System.Threading.Tasks.Dataflow.T> filter, out T item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList`1 items) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public BufferBlock<T> () {}
//ctor: 
public BufferBlock<T> (System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) {}
   public int Count { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("b744d4fb-3026-3e37-a7c8-8ad6fce89f7d")]
  public sealed class JoinBlock`2 : System.Object IReceivableSourceBlock<System.Tuple>, Internal.IDebuggerDisplay
{
    public virtual IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<Tuple> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<Tuple> filter, out Tuple`2 item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList`1 items) { throw new NotImplementedException(); }
    public virtual void Complete() {}
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public JoinBlock<T1,T2> () {}
//ctor: 
public JoinBlock<T1,T2> (System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) {}
   public int OutputCount { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
   public ITargetBlock<System.Threading.Tasks.Dataflow.T1> Target1 { get; }
   public ITargetBlock<System.Threading.Tasks.Dataflow.T2> Target2 { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("4252ebbf-bb55-33ed-8d5c-8eba93026e7e")]
  public sealed class JoinBlock`3 : System.Object IReceivableSourceBlock<System.Tuple>, Internal.IDebuggerDisplay
{
    public virtual IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<Tuple> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<Tuple> filter, out Tuple`3 item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList`1 items) { throw new NotImplementedException(); }
    public virtual void Complete() {}
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public JoinBlock<T1,T2,T3> () {}
//ctor: 
public JoinBlock<T1,T2,T3> (System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) {}
   public int OutputCount { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
   public ITargetBlock<System.Threading.Tasks.Dataflow.T1> Target1 { get; }
   public ITargetBlock<System.Threading.Tasks.Dataflow.T2> Target2 { get; }
   public ITargetBlock<System.Threading.Tasks.Dataflow.T3> Target3 { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("cad361b6-f30f-337a-9baf-5c00f8ee091a")]
  public sealed class TransformBlock`2 : System.Object IPropagatorBlock<System.Threading.Tasks.Dataflow.TInput,System.Threading.Tasks.Dataflow.TOutput>, IReceivableSourceBlock<System.Threading.Tasks.Dataflow.TOutput>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public virtual IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.TOutput> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<System.Threading.Tasks.Dataflow.TOutput> filter, out TOutput item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList`1 items) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public TransformBlock<TInput,TOutput> (Func<System.Threading.Tasks.Dataflow.TInput,System.Threading.Tasks.Dataflow.TOutput> transform) {}
//ctor: 
public TransformBlock<TInput,TOutput> (Func<System.Threading.Tasks.Dataflow.TInput,System.Threading.Tasks.Dataflow.TOutput> transform, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
//ctor: 
public TransformBlock<TInput,TOutput> (Func<System.Threading.Tasks.Dataflow.TInput,System.Threading.Tasks.Task> transform) {}
//ctor: 
public TransformBlock<TInput,TOutput> (Func<System.Threading.Tasks.Dataflow.TInput,System.Threading.Tasks.Task> transform, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
   public virtual System.Threading.Tasks.Task Completion { get; }
   public int InputCount { get; }
   public int OutputCount { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("ae765028-ed82-3da5-9f2c-988a1082cbef")]
  public sealed class TransformManyBlock`2 : System.Object IPropagatorBlock<System.Threading.Tasks.Dataflow.TInput,System.Threading.Tasks.Dataflow.TOutput>, IReceivableSourceBlock<System.Threading.Tasks.Dataflow.TOutput>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public virtual IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.TOutput> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<System.Threading.Tasks.Dataflow.TOutput> filter, out TOutput item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList`1 items) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public TransformManyBlock<TInput,TOutput> (Func<System.Threading.Tasks.Dataflow.TInput,System.Collections.Generic.IEnumerable> transform) {}
//ctor: 
public TransformManyBlock<TInput,TOutput> (Func<System.Threading.Tasks.Dataflow.TInput,System.Collections.Generic.IEnumerable> transform, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
//ctor: 
public TransformManyBlock<TInput,TOutput> (Func<System.Threading.Tasks.Dataflow.TInput,System.Threading.Tasks.Task> transform) {}
//ctor: 
public TransformManyBlock<TInput,TOutput> (Func<System.Threading.Tasks.Dataflow.TInput,System.Threading.Tasks.Task> transform, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
   public virtual System.Threading.Tasks.Task Completion { get; }
   public int InputCount { get; }
   public int OutputCount { get; }
  }


// Source:  d:/Beta/dotData/System.Threading.Tasks.Dataflow.dll  Build 4.6.24027.00
[Guid("b7cac38b-986b-3d73-b43b-3170188f2aef")]
  public sealed class WriteOnceBlock`1 : System.Object IPropagatorBlock<System.Threading.Tasks.Dataflow.T,System.Threading.Tasks.Dataflow.T>, IReceivableSourceBlock<System.Threading.Tasks.Dataflow.T>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public virtual bool TryReceive(Predicate<System.Threading.Tasks.Dataflow.T> filter, out T item) { throw new NotImplementedException(); }
    public virtual IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Threading.Tasks.Dataflow.T> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public WriteOnceBlock<T> (Func<System.Threading.Tasks.Dataflow.T,System.Threading.Tasks.Dataflow.T> cloningFunction) {}
//ctor: 
public WriteOnceBlock<T> (Func<System.Threading.Tasks.Dataflow.T,System.Threading.Tasks.Dataflow.T> cloningFunction, DataflowBlockOptions dataflowBlockOptions) {}
   public virtual System.Threading.Tasks.Task Completion { get; }
  }
