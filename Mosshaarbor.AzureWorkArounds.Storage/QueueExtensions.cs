using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mosshaarbor.AzureWorkArounds.Storage
{
    public static class QueueExtensions
    {
#if NETSTANDARD2_0

        public static void FetchAttributes(this CloudQueue queue)
        {
            queue.FetchAttributesAsync().Wait();
        }

        public static bool CreateIfNotExists(this CloudQueue queue)
        {
            return queue.CreateIfNotExistsAsync().Result;
        }

        public static void DeleteMessage(this CloudQueue queue, CloudQueueMessage message)
        {
            queue.DeleteMessageAsync(message).Wait();
        }

        public static void DeleteMessage(this CloudQueue queue, string messageId, string popReceipt, QueueRequestOptions options)
        {
            queue.DeleteMessageAsync(messageId, popReceipt, options, null).Wait();
        }

        public static void DeleteMessage(this CloudQueue queue, string messageId, string popReceipt, QueueRequestOptions options, Microsoft.WindowsAzure.Storage.OperationContext operationContext)
        {
            queue.DeleteMessageAsync(messageId, popReceipt, options, operationContext).Wait();
        }

        public static void DeleteMessage(this CloudQueue queue, string messageId, string popReceipt)
        {
            queue.DeleteMessageAsync(messageId, popReceipt).Wait();
        }

        public static void DeleteMessage(this CloudQueue queue, CloudQueueMessage message, QueueRequestOptions options, Microsoft.WindowsAzure.Storage.OperationContext operationContext)
        {
            queue.DeleteMessageAsync(message, options, operationContext).Wait();
        }

        public static CloudQueueMessage GetMessage(this CloudQueue queue)
        {
            return queue.GetMessageAsync().Result;
        }

        public static CloudQueueMessage GetMessage(this CloudQueue queue, TimeSpan? visibilityTimeout, QueueRequestOptions options, Microsoft.WindowsAzure.Storage.OperationContext operationContext)
        {
            return queue.GetMessageAsync(visibilityTimeout, options, operationContext).Result;
        }

        public static IEnumerable<CloudQueueMessage> GetMessages(this CloudQueue queue, int messageCount, TimeSpan? visibilityTimeout, QueueRequestOptions options)
        {
            return queue.GetMessagesAsync(messageCount, visibilityTimeout, options, null).Result;
        }

        public static IEnumerable<CloudQueueMessage> GetMessages(this CloudQueue queue, int messageCount, TimeSpan? visibilityTimeout, QueueRequestOptions options, Microsoft.WindowsAzure.Storage.OperationContext operationContext)
        {
            return queue.GetMessagesAsync(messageCount, visibilityTimeout, options, operationContext).Result;
        }

        public static IEnumerable<CloudQueueMessage> GetMessages(this CloudQueue queue, int messageCount)
        {
            return queue.GetMessagesAsync(messageCount).Result;
        }

        public static bool Exists(this CloudQueue queue)
        {
            return queue.ExistsAsync().Result;
        }

        public static void AddMessage(this CloudQueue queue, CloudQueueMessage message)
        {
            queue.AddMessageAsync(message).Wait();
        }

        public static void AddMessage(this CloudQueue queue, CloudQueueMessage message, TimeSpan? timeToLive, TimeSpan? initialVisibilityDelay, QueueRequestOptions options, Microsoft.WindowsAzure.Storage.OperationContext operationContext)
        {
            queue.AddMessageAsync(message, timeToLive, initialVisibilityDelay, options, operationContext).Wait();
        }

        public static void Clear(this CloudQueue queue, QueueRequestOptions options, Microsoft.WindowsAzure.Storage.OperationContext operationContext)
        {
            queue.ClearAsync(options, operationContext).Wait();

        }
        public static void Clear(this CloudQueue queue)
        {
            queue.ClearAsync().Wait();
        }
#endif
    }
}
