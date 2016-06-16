﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Reactions API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developer.github.com/v3/reactions">Reactions API documentation</a> for more information.
    /// </remarks>
    public interface IIssueCommentReactionsClient
    {
        /// <summary>
        /// Creates a reaction for a specified Issue Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#create-reaction-for-an-issue-comment</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The comment id</param>
        /// <param name="reaction">The reaction to create</param>
        /// <returns></returns>
        Task<Reaction> Create(string owner, string name, int number, NewReaction reaction);

        /// <summary>
        /// Creates a reaction for a specified Issue Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#create-reaction-for-an-issue-comment</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The comment id</param>
        /// <param name="reaction">The reaction to create</param>
        /// <returns></returns>
        Task<Reaction> Create(int repositoryId, int number, NewReaction reaction);

        /// <summary>
        /// Get all reactions for a specified Issue Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-an-issue-comment</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The comment id</param>        
        /// <returns></returns>
        Task<IReadOnlyList<Reaction>> GetAll(string owner, string name, int number);
        
        /// <summary>
        /// Get all reactions for a specified Issue Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-an-issue-comment</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The comment id</param>        
        /// <returns></returns>
        Task<IReadOnlyList<Reaction>> GetAll(int repositoryId, int number);
    }
}
