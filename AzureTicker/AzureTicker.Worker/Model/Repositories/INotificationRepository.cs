﻿using AzureTicker.Worker.Model.TableStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AzureTicker.Worker.Model.Repositories
{
    interface INotificationRepository: IDisposable
    {   
        string AddOrUpdate(Notification notification);

        void Update(Notification notification);

        bool Delete(string rowKey);

        void SaveChanges();

        void Clear();

        Notification GetByRowKey(string AppId);

        IEnumerable<Notification> List();

        IEnumerable<Notification> GetNotificationsToUpdate();

        IEnumerable<Notification> GetNotificationsToSend();

        void UpdateBalance(Notification notification, string newBalance);
        
    }
}
