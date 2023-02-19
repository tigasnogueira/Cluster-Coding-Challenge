using Cluster.Domain.Notifications;

namespace Cluster.Domain.Interfaces;

public interface INotifier
{
    bool HasNotification();
    List<Notification> GetNotifications();
    void Handle(Notification notification);
}
