
namespace System.Threading.Tasks.Dataflow
{  

// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("cae8c8ba-a95e-3318-9fea-008f0169bb96")]
  public abstract sealed class DataflowBlock<TInput, TOutput> // : System.Object
{
    public static IDisposable LinkTo(ISourceBlock<TOutput> source, ITargetBlock<TOutput> target) { throw new NotImplementedException(); }
    public static IDisposable LinkTo(ISourceBlock<TOutput> source, ITargetBlock<TOutput> target, Predicate<TOutput> predicate) { throw new NotImplementedException(); }
    public static IDisposable LinkTo(ISourceBlock<TOutput> source, ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions, Predicate<TOutput> predicate) { throw new NotImplementedException(); }
    public static bool Post<TInput>(ITargetBlock<TInput> target, TInput item) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<bool> SendAsync(ITargetBlock<TInput> target, TInput item) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<bool> SendAsync(ITargetBlock<TInput> target, TInput item, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static bool TryReceive(IReceivableSourceBlock<TOutput> source, out TOutput item) { throw new NotImplementedException(); }
    
    public static void ReceiveAsync(ISourceBlock<TOutput> source) { throw new NotImplementedException(); }
    public static void ReceiveAsync(ISourceBlock<TOutput> source, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static void ReceiveAsync(ISourceBlock<TOutput> source, TimeSpan timeout) { throw new NotImplementedException(); }
    public static void ReceiveAsync(ISourceBlock<TOutput> source, TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static void Receive(ISourceBlock<TOutput> source) { throw new NotImplementedException(); }
    public static void Receive(ISourceBlock<TOutput> source, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static void Receive(ISourceBlock<TOutput> source, TimeSpan timeout) { throw new NotImplementedException(); }
    public static void Receive(ISourceBlock<TOutput> source, TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<bool> OutputAvailableAsync(ISourceBlock<TOutput> source) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<bool> OutputAvailableAsync(ISourceBlock<TOutput> source, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
    public static void Encapsulate(ITargetBlock<TInput> target, ISourceBlock<TOutput> source) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<int> Choose<T1, T2>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<int> Choose<T1, T2>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, DataflowBlockOptions dataflowBlockOptions) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<int> Choose<T1, T2, T3>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, ISourceBlock<T3> source3, Action<T3> action3) { throw new NotImplementedException(); }
    public static System.Threading.Tasks.Task<int> Choose<T1, T2, T3>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, ISourceBlock<T3> source3, Action<T3> action3, DataflowBlockOptions dataflowBlockOptions) { throw new NotImplementedException(); }
    public static void AsObservable(ISourceBlock<TOutput> source) { throw new NotImplementedException(); }
    public static void AsObserver(ITargetBlock<TInput> target) { throw new NotImplementedException(); }
    public static void NullTarget() { throw new NotImplementedException(); }
    public virtual override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
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


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
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


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
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


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
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


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("876e8921-0a02-3cea-b675-36c529033558")]
  public sealed struct DataflowMessageHeader : // System.ValueType 
    System.IEquatable<DataflowMessageHeader>
{
    public virtual bool Equals(DataflowMessageHeader other) { throw new NotImplementedException(); }
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


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
  [Guid("437dea44-21f4-34e6-852a-d42494896cd7")]
  public sealed enum DataflowMessageStatus // // : System.Enum
  {
     // // public static override bool TryParse(string value, out TEnum result) { throw new NotImplementedException(); }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("e1bd6ca2-ca92-3066-abaf-1a792727fc4a")]
  public interface IDataflowBlock
{
    void Complete();
    void Fault(Exception exception);
    System.Threading.Tasks.Task Completion { get; }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("78ebd1af-0468-358a-b2e7-fd79469b946b")]
  public interface IPropagatorBlock<TInput, TOutput> : ITargetBlock<TInput>, ISourceBlock<TOutput>
{

  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("0ea62736-976e-31e6-9472-159adf33c413")]
  public interface IReceivableSourceBlock<TOutput> : ISourceBlock<TOutput>
{
    bool TryReceive(Predicate<TOutput> filter, out TOutput item);
    bool TryReceiveAll(out System.Collections.Generic.IList<TOutput> items);
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("e986232a-4388-39df-ac79-96b754e76439")]
  public interface ISourceBlock<TOutput> : IDataflowBlock
{
    IDisposable LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions);
    void ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target, out bool messageConsumed);
    bool ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target);
    void ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target);
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("e4e18fdc-aef4-309d-a150-4b9e171dcf79")]
  public interface ITargetBlock<TInput> : IDataflowBlock
{
    DataflowMessageStatus OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept);
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("b08580c0-0b9e-341e-b117-d16aa00ba932")]
  public sealed class ActionBlock<TInput> : ITargetBlock<TInput> //, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public bool Post(TInput item) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }

    //ctor: 
public ActionBlock<TInput> (Action<TInput> action) {}
//ctor: 
public ActionBlock<TInput> (Action<TInput> action, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
//ctor: 
public ActionBlock<TInput> (Func<TInput,System.Threading.Tasks.Task> action) {}
//ctor: 
public ActionBlock<TInput> (Func<TInput,System.Threading.Tasks.Task> action, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
   public virtual System.Threading.Tasks.Task Completion { get; }
   public int InputCount { get; }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("b346466d-3c48-3b46-af57-87ae4f3e8119")]
  public sealed class BatchBlock<T> : IPropagatorBlock<T,T[]>, IReceivableSourceBlock<T[]>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public void TriggerBatch() {}
    public virtual IDisposable LinkTo(ITargetBlock<T[]> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<T[]> filter, out T[] item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList<T> items) { throw new NotImplementedException(); }
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


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("44e7eb60-d4df-3624-8ffe-fae45a7eb0eb")]
  public sealed class BatchedJoinBlock<T> : IReceivableSourceBlock<System.Tuple>, Internal.IDebuggerDisplay
{
    public virtual IDisposable LinkTo(ITargetBlock<Tuple> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<Tuple> filter, out Tuple<A,B> item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList<T> items) { throw new NotImplementedException(); }
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
   public ITargetBlock<T1> Target1 { get; }
   public ITargetBlock<T2> Target2 { get; }
   public int OutputCount { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("d0751974-ed58-31b7-bdc1-4c5705794bc9")]
  public sealed class BatchedJoinBlock<A, B, C> : IReceivableSourceBlock<System.Tuple>, Internal.IDebuggerDisplay
{
    public virtual IDisposable LinkTo(ITargetBlock<Tuple> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<Tuple> filter, out Tuple<A,B,C> item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList<T> items) { throw new NotImplementedException(); }
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
   public ITargetBlock<T1> Target1 { get; }
   public ITargetBlock<T2> Target2 { get; }
   public ITargetBlock<T3> Target3 { get; }
   public int OutputCount { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("17d9f543-aac8-3b38-88cd-b796f1d5af79")]
  public sealed class BroadcastBlock<T> : IPropagatorBlock<T,T>, IReceivableSourceBlock<T>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public virtual IDisposable LinkTo(ITargetBlock<T> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<T> filter, out T item) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public BroadcastBlock<T> (Func<T,T> cloningFunction) {}
//ctor: 
public BroadcastBlock<T> (Func<T,T> cloningFunction, DataflowBlockOptions dataflowBlockOptions) {}
   public virtual System.Threading.Tasks.Task Completion { get; }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("43c2f03a-2f94-3de6-b639-c39d572e3acb")]
  public sealed class BufferBlock<T> : IPropagatorBlock<T,T>, IReceivableSourceBlock<T>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public virtual IDisposable LinkTo(ITargetBlock<T> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<T> filter, out T item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList<T> items) { throw new NotImplementedException(); }
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
public BufferBlock<T> (DataflowBlockOptions dataflowBlockOptions) {}
   public int Count { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("b744d4fb-3026-3e37-a7c8-8ad6fce89f7d")]
  public sealed class JoinBlock<A,B> : IReceivableSourceBlock<System.Tuple>, Internal.IDebuggerDisplay
{
    public virtual IDisposable LinkTo(ITargetBlock<Tuple> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<Tuple> filter, out Tuple<A,B> item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList<T> items) { throw new NotImplementedException(); }
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
public JoinBlock<T1,T2> (GroupingDataflowBlockOptions dataflowBlockOptions) {}
   public int OutputCount { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
   public ITargetBlock<T1> Target1 { get; }
   public ITargetBlock<T2> Target2 { get; }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("4252ebbf-bb55-33ed-8d5c-8eba93026e7e")]
  public sealed class JoinBlock<A,B,C> : IReceivableSourceBlock<System.Tuple>, Internal.IDebuggerDisplay
{
    public virtual IDisposable LinkTo(ITargetBlock<Tuple> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<Tuple> filter, out Tuple<A,B,C> item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList<T> items) { throw new NotImplementedException(); }
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
public JoinBlock<T1,T2,T3> (GroupingDataflowBlockOptions dataflowBlockOptions) {}
   public int OutputCount { get; }
   public virtual System.Threading.Tasks.Task Completion { get; }
   public ITargetBlock<T1> Target1 { get; }
   public ITargetBlock<T2> Target2 { get; }
   public ITargetBlock<T3> Target3 { get; }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("cad361b6-f30f-337a-9baf-5c00f8ee091a")]
  public sealed class TransformBlock<A,B> : IPropagatorBlock<TInput,TOutput>, IReceivableSourceBlock<TOutput>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public virtual IDisposable LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<TOutput> filter, out TOutput item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList<T> items) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public TransformBlock<TInput,TOutput> (Func<TInput,TOutput> transform) {}
//ctor: 
public TransformBlock<TInput,TOutput> (Func<TInput,TOutput> transform, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
//ctor: 
public TransformBlock<TInput,TOutput> (Func<TInput,System.Threading.Tasks.Task> transform) {}
//ctor: 
public TransformBlock<TInput,TOutput> (Func<TInput,System.Threading.Tasks.Task> transform, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
   public virtual System.Threading.Tasks.Task Completion { get; }
   public int InputCount { get; }
   public int OutputCount { get; }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("ae765028-ed82-3da5-9f2c-988a1082cbef")]
  public sealed class TransformManyBlock<A,B> : IPropagatorBlock<TInput,TOutput>, IReceivableSourceBlock<TOutput>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public virtual IDisposable LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public virtual bool TryReceive(Predicate<TOutput> filter, out TOutput item) { throw new NotImplementedException(); }
    public virtual bool TryReceiveAll(out System.Collections.Generic.IList<T> items) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public TransformManyBlock<TInput,TOutput> (Func<TInput,System.Collections.Generic.IEnumerable> transform) {}
//ctor: 
public TransformManyBlock<TInput,TOutput> (Func<TInput,System.Collections.Generic.IEnumerable> transform, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
//ctor: 
public TransformManyBlock<TInput,TOutput> (Func<TInput,System.Threading.Tasks.Task> transform) {}
//ctor: 
public TransformManyBlock<TInput,TOutput> (Func<TInput,System.Threading.Tasks.Task> transform, ExecutionDataflowBlockOptions dataflowBlockOptions) {}
   public virtual System.Threading.Tasks.Task Completion { get; }
   public int InputCount { get; }
   public int OutputCount { get; }
  }


// Source:  d:/Beta/dotData/dll  Build 4.6.24027.00
[Guid("b7cac38b-986b-3d73-b43b-3170188f2aef")]
  public sealed class WriteOnceBlock<T> : IPropagatorBlock<T,T>, IReceivableSourceBlock<T>, Internal.IDebuggerDisplay
{
    public virtual void Complete() {}
    public virtual bool TryReceive(Predicate<T> filter, out T item) { throw new NotImplementedException(); }
    public virtual IDisposable LinkTo(ITargetBlock<T> target, DataflowLinkOptions linkOptions) { throw new NotImplementedException(); }
    public override string ToString() { throw new NotImplementedException(); }
    public virtual override bool Equals(object obj) { throw new NotImplementedException(); }
    public static override bool Equals(object objA, object objB) { throw new NotImplementedException(); }
    public static override bool ReferenceEquals(object objA, object objB) { throw new NotImplementedException(); }
    public virtual override int GetHashCode() { throw new NotImplementedException(); }
    public override Type GetType() { throw new NotImplementedException(); }
    protected virtual override void Finalize() {}
    protected override object MemberwiseClone() { throw new NotImplementedException(); }
//ctor: 
public WriteOnceBlock<T> (Func<T,T> cloningFunction) {}
//ctor: 
public WriteOnceBlock<T> (Func<T,T> cloningFunction, DataflowBlockOptions dataflowBlockOptions) {}
   public virtual System.Threading.Tasks.Task Completion { get; }
  }

}

}